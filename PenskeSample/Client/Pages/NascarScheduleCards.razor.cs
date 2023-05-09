using System.Net.Http.Json;
using PenskeSampleSdk.Shared.ViewModel_Dto;

namespace PenskeSample.Client.Pages
{
    public partial class NascarScheduleCards
    {
        public List<RaceSeriesScheduleDto>? RaceSeriesScheduleDto { get; internal set; }

        public string GetColor(int num)
        {
            switch (num)
            {
                case 1:
                    return "red";
                case 2:
                    return "blue";
                case 3:
                    return "yellow";
                default:
                    return "white";
            }
        }

        protected override async Task OnInitializedAsync()
        {
            var response = await Http.GetFromJsonAsync<ApiResponse<List<RaceSeriesScheduleDto>>>("RaceSchedule");
            RaceSeriesScheduleDto = response?.Data;
        }
    }
}