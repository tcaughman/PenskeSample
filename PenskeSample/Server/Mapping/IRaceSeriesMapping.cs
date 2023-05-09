using PenskeSampleApi.Server.Entities;
using PenskeSampleSdk.Shared.ViewModel_Dto;

namespace PenskeSampleApi.Server.Mapping
{
    public interface IRaceSeriesMapping
    {
        Task<RaceSeriesScheduleDto> ToDto(RaceSeries raceSeries);
        Task<RaceSeries> ToEntity(List<RaceDetailDto> source);
    }
}