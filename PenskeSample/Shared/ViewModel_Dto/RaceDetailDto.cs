using System.Text.Json.Serialization;

namespace PenskeSampleSdk.Shared.ViewModel_Dto
{
    public class RaceDetailDto
    {
        [JsonPropertyName("race_id")]
        public int RaceId { get; set; }

        [JsonPropertyName("series_id")]
        public int SeriesId { get; set; }

        [JsonPropertyName("race_season")]
        public int RaceSeason { get; set; }

        [JsonPropertyName("race_name")]
        public string RaceName { get; set; }

        [JsonPropertyName("race_type_id")]
        public int RaceTypeId { get; set; }

        [JsonPropertyName("restrictor_plate")]
        public bool RestrictorPlate { get; set; }

        [JsonPropertyName("track_id")]
        public int TrackId { get; set; }

        [JsonPropertyName("track_name")]
        public string TrackName { get; set; }

        [JsonPropertyName("date_scheduled")]
        public DateTime DateScheduled { get; set; }

        [JsonPropertyName("race_date")]
        public DateTime RaceDate { get; set; }

        [JsonPropertyName("qualifying_date")]
        public DateTime QualifyingDate { get; set; }

        [JsonPropertyName("tunein_date")]
        public DateTime TuneinDate { get; set; }

        [JsonPropertyName("scheduled_distance")]
        public double ScheduledDistance { get; set; }

        [JsonPropertyName("actual_distance")]
        public double ActualDistance { get; set; }

        [JsonPropertyName("scheduled_laps")]
        public int ScheduledLaps { get; set; }

        [JsonPropertyName("actual_laps")]
        public int ActualLaps { get; set; }

        [JsonPropertyName("stage_1_laps")]
        public int Stage1Laps { get; set; }

        [JsonPropertyName("stage_2_laps")]
        public int Stage2Laps { get; set; }

        [JsonPropertyName("stage_3_laps")]
        public int Stage3Laps { get; set; }

        [JsonPropertyName("number_of_cars_in_field")]
        public int NumberOfCarsInField { get; set; }

        [JsonPropertyName("pole_winner_driver_id")]
        public int PoleWinnerDriverId { get; set; }

        [JsonPropertyName("pole_winner_speed")]
        public double PoleWinnerSpeed { get; set; }

        [JsonPropertyName("number_of_lead_changes")]
        public int NumberOfLeadChanges { get; set; }

        [JsonPropertyName("number_of_leaders")]
        public int NumberOfLeaders { get; set; }

        [JsonPropertyName("number_of_cautions")]
        public int NumberOfCautions { get; set; }

        [JsonPropertyName("number_of_caution_laps")]
        public int NumberOfCautionLaps { get; set; }

        [JsonPropertyName("average_speed")]
        public double AverageSpeed { get; set; }

        [JsonPropertyName("total_race_time")]
        public string TotalRaceTime { get; set; }

        [JsonPropertyName("margin_of_victory")]
        public string MarginOfVictory { get; set; }

        [JsonPropertyName("race_purse")]
        public int RacePurse { get; set; }

        [JsonPropertyName("race_comments")]
        public string RaceComments { get; set; }

        [JsonPropertyName("attendance")]
        public int Attendance { get; set; }

        [JsonPropertyName("infractions")]
        public List<object> Infractions { get; set; }

        [JsonPropertyName("schedule")]
        public List<RaceDetailScheduleDto>? Schedule { get; set; }

        [JsonPropertyName("radio_broadcaster")]
        public string RadioBroadcaster { get; set; }

        [JsonPropertyName("television_broadcaster")]
        public string TelevisionBroadcaster { get; set; }

        [JsonPropertyName("satellite_radio_broadcaster")]
        public string SatelliteRadioBroadcaster { get; set; }

        [JsonPropertyName("master_race_id")]
        public int MasterRaceId { get; set; }

        [JsonPropertyName("inspection_complete")]
        public bool InspectionComplete { get; set; }

        [JsonPropertyName("playoff_round")]
        public int PlayoffRound { get; set; }

        [JsonPropertyName("is_qualifying_race")]
        public bool IsQualifyingRace { get; set; }

        [JsonPropertyName("qualifying_race_no")]
        public int QualifyingRaceNo { get; set; }

        [JsonPropertyName("qualifying_race_id")]
        public int QualifyingRaceId { get; set; }

        [JsonPropertyName("has_qualifying")]
        public bool HasQualifying { get; set; }

        [JsonPropertyName("winner_driver_id")]
        public int? WinnerDriverId { get; set; }

        [JsonPropertyName("pole_winner_laptime")]
        public object PoleWinnerLaptime { get; set; }
    }

}
