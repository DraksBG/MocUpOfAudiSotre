namespace MocUpOfAudiStore.Data.Repositories
{
    using Interfaces;
    using Models;

    public class OptionTypeRepository : BaseRepository<OptionType>, IOptionTypeRepository
    {
        public OptionTypeRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}