using PenskeSample.Shared.ViewModel_Dto;
using PenskeSampleApi.Server.Entities;
using PenskeSampleSdk.Shared.ViewModel_Dto;

namespace PenskeSampleApi.Server.Mapping
{
    public class RaceSeriesMapping : IRaceSeriesMapping
    {
        public async Task<RaceSeries> ToEntity(List<RaceDetailDto> source)
        {
            var raceSeries = new RaceSeries()
            {
                RaceSeriesId = source.First().SeriesId,
                RaceDetails = new()
            };

            foreach (var item in source)
            {
                var raceSeriesDetail = new RaceSeriesDetail
                {
                    ActualDistance = item.ActualDistance,
                    Attendance = item.Attendance,
                    ActualLaps = item.ActualLaps,
                    AverageSpeed = item.AverageSpeed,
                    DateScheduled = item.DateScheduled,
                    HasQualifying = item.HasQualifying,
                    Infractions = item.Infractions,
                    InspectionComplete = item.InspectionComplete,
                    IsQualifyingRace = item.IsQualifyingRace,
                    MarginOfVictory = item.MarginOfVictory,
                    MasterRaceId = item.MasterRaceId,
                    NumberOfCarsInField = item.NumberOfCarsInField,
                    NumberOfCautionLaps = item.NumberOfCautionLaps,
                    NumberOfCautions = item.NumberOfCautions,
                    NumberOfLeadChanges = item.NumberOfLeadChanges,
                    NumberOfLeaders = item.NumberOfLeaders,
                    PlayoffRound = item.PlayoffRound,
                    PoleWinnerDriverId = item.PoleWinnerDriverId,
                    PoleWinnerLaptime = item.PoleWinnerLaptime,
                    PoleWinnerSpeed = item.PoleWinnerSpeed,
                    QualifyingDate = item.QualifyingDate,
                    QualifyingRaceId = item.QualifyingRaceId,
                    QualifyingRaceNo = item.QualifyingRaceNo,
                    RaceComments = item.RaceComments,
                    RaceDate = item.RaceDate,
                    RaceId = item.RaceId,
                    RaceName = item.RaceName,
                    RacePurse = item.RacePurse,
                    RaceSeason = item.RaceSeason,
                    RaceTypeId = item.RaceTypeId,
                    RadioBroadcaster = item.RadioBroadcaster,
                    RestrictorPlate = item.RestrictorPlate,
                    SatelliteRadioBroadcaster = item.SatelliteRadioBroadcaster,
                    Schedule = item.Schedule != null ? await DtoToScheduleEntity(item.Schedule) : null,
                    ScheduledDistance = item.ScheduledDistance,
                    ScheduledLaps = item.ScheduledLaps,
                    SeriesId = item.SeriesId,
                    Stage1Laps = item.Stage1Laps,
                    Stage2Laps = item.Stage2Laps,
                    Stage3Laps = item.Stage3Laps,
                    TelevisionBroadcaster = item.TelevisionBroadcaster,
                    TotalRaceTime = item.TotalRaceTime,
                    TrackId = item.TrackId,
                    TrackName = item.TrackName,
                    TuneinDate = item.TuneinDate,
                    WinnerDriverId = item.WinnerDriverId
                };

                raceSeries.RaceDetails.Add(raceSeriesDetail);

            }

            return raceSeries;

            async Task<List<Schedule>> DtoToScheduleEntity(List<RaceDetailScheduleDto> raceDetailSchedules)
            {
                var schedules = new List<Schedule>();

                foreach (var item in raceDetailSchedules)
                {
                    schedules.Add(new Schedule
                    {
                        EventName = item.EventName,
                        Notes = item.Notes,
                        RunType = item.RunType,
                        StartTimeUtc = item.StartTimeUtc
                    });
                }

                return schedules;
            }
        }

        public async Task<RaceSeriesScheduleDto> ToDto(RaceSeries raceSeries)
        {
            var raceSeriesScheduleDto = new RaceSeriesScheduleDto(raceSeries.RaceSeriesId);
            await RaceSeriesDetailToRaceScheduleDto(raceSeries.RaceDetails);


            async Task RaceSeriesDetailToRaceScheduleDto(List<RaceSeriesDetail> raceSeriesDetails)
            {
                foreach (var detail in raceSeriesDetails)
                {
                    var raceschdDto = new RaceScheduleDto(
                            raceSeriesId: detail.SeriesId,
                            raceId: detail.RaceId,
                            raceEventName: detail?.RaceName,
                            raceEventTrackName: detail?.TrackName,
                            dateScheduled: detail.DateScheduled,
                            scheduledLaps: detail?.ScheduledLaps,
                            scheduledDistance: detail?.ScheduledDistance
                        );

                    raceSeriesScheduleDto.RaceSchedules.Add(raceschdDto);

                }
            }

            return raceSeriesScheduleDto;
        }

    }
}
