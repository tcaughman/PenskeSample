namespace PenskeSampleSdk.Shared.ViewModel_Dto
{
    public class RaceSeriesDto
    {
        public RaceSeriesDto(List<RaceDetailDto>? raceDetail)
        {
            RaceDetail = raceDetail ?? throw new ArgumentNullException(nameof(raceDetail));
            RaceSeriesId = raceDetail.First().SeriesId;
        }

        public int RaceSeriesId { get; set; }

        public List<RaceDetailDto>? RaceDetail { get; set; }
    }
}
