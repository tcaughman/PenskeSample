using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using PenskeSample.Client.Shared;
using PenskeSampleSdk.Shared.ViewModel_Dto;

namespace PenskeSample.Client.Pages
{
    public partial class NascarSchedule
    {
        private List<RaceSeriesScheduleDto>? raceSeriesScheduleDto;
        protected override async Task OnInitializedAsync()
        {
            var response = await Http.GetFromJsonAsync<ApiResponse<List<RaceSeriesScheduleDto>>>("RaceSchedule");
            raceSeriesScheduleDto = response?.Data;
        }
    }
}