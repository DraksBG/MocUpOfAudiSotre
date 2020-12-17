namespace MocUpOfAudiStore.Data.Repositories
{
    using Interfaces;
    using Models;

    public class OptionRepository : BaseRepository<Option>, IOptionRepository
    {
        public OptionRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}