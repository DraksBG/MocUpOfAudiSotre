namespace MocUpOfAudiStore.Data.Repositories
{
    using Interfaces;
    using Models;

    public class FuelTypeRepository : BaseRepository<FuelType>, IFuelTypeRepository
    {
        public FuelTypeRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}