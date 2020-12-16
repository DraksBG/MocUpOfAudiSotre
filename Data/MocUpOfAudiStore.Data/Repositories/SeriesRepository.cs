namespace MocUpOfAudiStore.Data.Repositories
{
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class SeriesRepository : BaseRepository<Series>, ISeriesRepository
    {
        public SeriesRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }
    }
}
