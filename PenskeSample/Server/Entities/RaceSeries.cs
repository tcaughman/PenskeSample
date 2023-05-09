using System.ComponentModel.DataAnnotations;

namespace PenskeSampleApi.Server.Entities
{
    public class RaceSeries
    {
        public int Id { get; set; }        
        public int RaceSeriesId { get; set; }
        public List<RaceSeriesDetail>? RaceDetails { get; set; }
    }
}
