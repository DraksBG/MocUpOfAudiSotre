namespace MocUpOfAudiStore.Data.Repositories
{
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class OptionRepository : BaseRepository<Option>, IOptionRepository
    {
        public OptionRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }
    }
}
