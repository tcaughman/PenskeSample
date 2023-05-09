using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;
using PenskeSampleApi.Server.Entities;
using PenskeSampleApi.Server.Mapping;
using PenskeSampleApi.Server.Repository;
using PenskeSampleSdk.Shared.ViewModel_Dto;
using System.Net;

namespace PenskeSampleApi.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RaceScheduleController : Controller
    {
        private readonly INascarRepository _nascarRepository;
        private readonly IRaceSeriesMapping _raceSeriesMapping;
        private readonly ILogger<RaceScheduleController> _logger;

        public RaceScheduleController(INascarRepository Repository, IRaceSeriesMapping mapping, ILogger<RaceScheduleController> logger)
        {
            _nascarRepository = Repository ?? throw new ArgumentException(nameof(Repository));
            _raceSeriesMapping = mapping ?? throw new ArgumentException(nameof(mapping));
            _logger = logger ?? throw new ArgumentException(nameof(logger));
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<List<RaceSeriesScheduleDto>>>> GetRaceSeriesSchedule()
        {
            List<RaceSeries> raceSeriesSchedule = await _nascarRepository.GetRaceSeriesAsync();
            var response = new List<RaceSeriesScheduleDto>();
            foreach (var item in raceSeriesSchedule)
            {
                response.Add(await _raceSeriesMapping.ToDto(item));
            }
            return new ApiResponse<List<RaceSeriesScheduleDto>>((int)HttpStatusCode.OK, response);
        }
    }
}
