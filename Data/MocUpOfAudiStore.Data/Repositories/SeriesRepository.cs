namespace MocUpOfAudiStore.Data.Repositories
{
    using Interfaces;
    using Models;

    public class SeriesRepository : BaseRepository<Series>, ISeriesRepository
    {
        public SeriesRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}