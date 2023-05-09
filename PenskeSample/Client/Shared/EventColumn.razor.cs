using Microsoft.AspNetCore.Components;
using PenskeSampleSdk.Shared.ViewModel_Dto;

namespace PenskeSample.Client.Shared
{
    public partial class EventColumn
    {
        [Parameter]
        public RaceSeriesScheduleDto? RaceSeriesScheduleDto { get; set; }

        [Parameter]
        public Func<int, string>? BackgroundColor { get; set; }

    }
}