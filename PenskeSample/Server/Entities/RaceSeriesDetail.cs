namespace PenskeSampleApi.Server.Entities
{
    public class RaceSeriesDetail
    {
        public int RaceId { get; set; }
        public int SeriesId { get; set; }
        public int? RaceSeason { get; set; }
        public string? RaceName { get; set; }
        public int? RaceTypeId { get; set; }
        public bool? RestrictorPlate { get; set; }
        public int? TrackId { get; set; }
        public string? TrackName { get; set; }
        public DateTime? DateScheduled { get; set; }
        public DateTime? RaceDate { get; set; }
        public DateTime? QualifyingDate { get; set; }
        public DateTime? TuneinDate { get; set; }
        public double? ScheduledDistance { get; set; }
        public double? ActualDistance { get; set; }
        public int? ScheduledLaps { get; set; }
        public int? ActualLaps { get; set; }
        public int? Stage1Laps { get; set; }
        public int? Stage2Laps { get; set; }
        public int? Stage3Laps { get; set; }
        public int? NumberOfCarsInField { get; set; }
        public int? PoleWinnerDriverId { get; set; }
        public double? PoleWinnerSpeed { get; set; }
        public int? NumberOfLeadChanges { get; set; }
        public int? NumberOfLeaders { get; set; }
        public int? NumberOfCautions { get; set; }
        public int? NumberOfCautionLaps { get; set; }
        public double? AverageSpeed { get; set; }
        public string? TotalRaceTime { get; set; }
        public string? MarginOfVictory { get; set; }
        public int? RacePurse { get; set; }
        public string? RaceComments { get; set; }
        public int? Attendance { get; set; }
        public List<object>? Infractions { get; set; }
        public List<Schedule>? Schedule { get; set; }
        public string? RadioBroadcaster { get; set; }
        public string? TelevisionBroadcaster { get; set; }
        public string? SatelliteRadioBroadcaster { get; set; }
        public int? MasterRaceId { get; set; }
        public bool? InspectionComplete { get; set; }
        public int? PlayoffRound { get; set; }
        public bool? IsQualifyingRace { get; set; }
        public int? QualifyingRaceNo { get; set; }
        public int? QualifyingRaceId { get; set; }
        public bool? HasQualifying { get; set; }
        public int? WinnerDriverId { get; set; }
        public object? PoleWinnerLaptime { get; set; }
    }
}
