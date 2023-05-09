using PenskeSample.Shared.ViewModel_Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenskeSampleSdk.Shared.ViewModel_Dto
{
    public class RaceSeriesScheduleDto
    {
        public RaceSeriesScheduleDto(int raceSeriesId) 
        {
            RaceSeriesId = raceSeriesId;
            RaceSeriesTypeEnum = (RaceSeriesTypeEnum)raceSeriesId;
        }
        
        public int RaceSeriesId { get; set; }

        public RaceSeriesTypeEnum RaceSeriesTypeEnum { get; set; }

        public List<RaceScheduleDto> RaceSchedules {get; set;} = new List<RaceScheduleDto>();

    }
}
