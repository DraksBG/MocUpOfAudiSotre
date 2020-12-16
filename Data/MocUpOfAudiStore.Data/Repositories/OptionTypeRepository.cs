namespace MocUpOfAudiStore.Data.Repositories
{
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class OptionTypeRepository : BaseRepository<OptionType>, IOptionTypeRepository
    {
        public OptionTypeRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
