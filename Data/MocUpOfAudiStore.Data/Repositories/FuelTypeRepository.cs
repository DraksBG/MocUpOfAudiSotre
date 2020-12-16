namespace MocUpOfAudiStore.Data.Repositories
{
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class FuelTypeRepository : BaseRepository<FuelType>, IFuelTypeRepository
    {
        public FuelTypeRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }
    }
}
