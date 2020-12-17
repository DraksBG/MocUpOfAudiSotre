namespace MocUpOfAudiStore.Data.Repositories
{
    using Interfaces;
    using Models;

    public class EngineRepository : BaseRepository<Engine>, IEngineRepository
    {
        public EngineRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}