using LiteDB;
using PenskeSampleApi.Server.Entities;
using PenskeSampleApi.Server.Mapping;
using PenskeSampleSdk.Shared.ViewModel_Dto;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PenskeSampleApi.Server.Repository
{
    public class NascarRepo : INascarRepository
    {
        private readonly string _liteDbConnectionString = $"{AppContext.BaseDirectory}\\{Constants.Constants.LITE_DB_FILEPATH}";
        private readonly string _sampleDataPath = $"{AppContext.BaseDirectory}\\{Constants.Constants.SAMPLE_DATA_PATH}";
        private readonly ILogger<NascarRepo> _logger;

        public NascarRepo(ILogger<NascarRepo> logger)
        {
            _logger = logger ?? throw new ArgumentException(nameof(logger));
        }

        public async Task InitializeNascarRepositoryAsync()
        {            
            try
            {
                var data = await File.ReadAllTextAsync(_sampleDataPath);
                var document = JsonDocument.Parse(data);

                var raceList = new List<List<RaceDetailDto>>();
                foreach (var item in document.RootElement.EnumerateObject().ToArray())
                {
                    raceList.Add(JsonSerializer.Deserialize<List<RaceDetailDto>>(item.Value.ToString()));
                }

                RaceSeriesMapping raceSeriesMapping = new RaceSeriesMapping();
                var RaceSeriesEntities = new List<RaceSeries>();
                foreach (var item in raceList)
                {
                    RaceSeriesEntities.Add(await raceSeriesMapping.ToEntity(item));
                }


                using (var db = new LiteDatabase($"{_liteDbConnectionString}"))
                {
                    if (!db.CollectionExists("raceSeries"))
                    {
                        var nascarScheduleCollection = db.GetCollection<RaceSeries>("raceSeries");
                        _ = nascarScheduleCollection.Upsert(RaceSeriesEntities);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to initialize database");
            }
        }

        public async Task<List<RaceSeries>> GetRaceSeriesAsync()
        {
            using var db = new LiteDatabase($"{_liteDbConnectionString}");
            var nascarSchedule = db.GetCollection<RaceSeries>().Query().OrderByDescending(x => x.RaceSeriesId).ToList();
            nascarSchedule.ForEach(raceSeries => raceSeries?.RaceDetails?.OrderBy(x => x.DateScheduled));
            return nascarSchedule;
        }

    }
}
