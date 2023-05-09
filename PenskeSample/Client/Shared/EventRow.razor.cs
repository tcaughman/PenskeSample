using Microsoft.AspNetCore.Components;
using PenskeSample.Shared.ViewModel_Dto;

namespace PenskeSample.Client.Shared
{
    public partial class EventRow
    {
        [Parameter]
        public RaceScheduleDto? RaceScheduleDto { get; set; }
    }
}