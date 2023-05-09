using PenskeSampleSdk.Shared.ViewModel_Dto;
using System.Globalization;

namespace PenskeSample.Shared.ViewModel_Dto
{
    public class RaceScheduleDto
    {
        public RaceScheduleDto(int raceSeriesId, int raceId, string raceEventName, 
            string raceEventTrackName, DateTime? dateScheduled, int? scheduledLaps, double? scheduledDistance)
        {
            RaceSeriesId = raceSeriesId;
            RaceId = raceId;
            RaceEventName = raceEventName;
            DateScheduled = dateScheduled;
            RaceEventTrackName = raceEventTrackName;
            ScheduledLaps = scheduledLaps;
            ScheduledDistance = scheduledDistance;
            ComputeRaceDisplayFormat();

        }
        public int RaceSeriesId { get; set; }       

        public int RaceId { get; set; }

        public string? RaceEventName { get; set; }

        public string? RaceEventTrackName { get; set; }

        public DateTime? DateScheduled { get; set; }

        public int? ScheduledLaps { get; set; }

        public double? ScheduledDistance { get; set; }

        public RaceDisplayDateFormat? RaceDateFormat { get; private set; } = new RaceDisplayDateFormat();

        private void ComputeRaceDisplayFormat()
        {
            DateTimeFormatInfo dateTimeFormatInfo = CultureInfo.CurrentCulture.DateTimeFormat;
            RaceDateFormat!.AbbreviatedMonth = dateTimeFormatInfo.GetAbbreviatedMonthName(DateScheduled!.Value.Month);
            RaceDateFormat.DayAsText = DateScheduled.Value.DayOfWeek.ToString();
            RaceDateFormat.Day = DateScheduled.Value.Day;
            RaceDateFormat.TimeAmPM = DateScheduled.Value.ToString("t");
        }
    }
}
