using System.Text.Json.Serialization;

namespace PenskeSampleSdk.Shared.ViewModel_Dto
{
    public class RaceDetailScheduleDto
    {
        [JsonPropertyName("event_name")]
        public string? EventName { get; set; }

        [JsonPropertyName("notes")]
        public string? Notes { get; set; }

        [JsonPropertyName("start_time_utc")]
        public DateTime? StartTimeUtc { get; set; }

        [JsonPropertyName("run_type")]
        public int? RunType { get; set; }
    }
}
