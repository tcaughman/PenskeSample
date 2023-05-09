namespace PenskeSampleApi.Server.Entities
{
    public class Schedule
    {
        public string? EventName { get; set; }
        public string? Notes { get; set; }
        public DateTime? StartTimeUtc { get; set; }
        public int? RunType { get; set; }
    }

}
