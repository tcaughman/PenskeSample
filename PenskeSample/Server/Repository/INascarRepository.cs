using PenskeSampleApi.Server.Entities;

namespace PenskeSampleApi.Server.Repository
{
    public interface INascarRepository
    {
        /// <summary>
        /// Get race series entity from on disk document database 
        /// </summary>
        /// <inheritdoc/>
        /// <returns>Task<List<RaceSeries>></returns>
        Task<List<RaceSeries>> GetRaceSeriesAsync();

        /// <summary>  
        /// Initialize on disk document database and create sample data 
        /// </summary>
        /// <inheritdoc />
        /// <returns></returns>
        Task InitializeNascarRepositoryAsync();
    }
}