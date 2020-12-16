namespace MocUpOfAudiStore.Data.Repositories
{
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class EngineRepository : BaseRepository<Engine>, IEngineRepository
    {
        public EngineRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }
    }
}
