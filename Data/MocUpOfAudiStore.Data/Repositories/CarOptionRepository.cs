namespace MocUpOfAudiStore.Data.Repositories
{
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Interfaces;
    using Models;

    public class CarOptionRepository : BaseRepository<CarOption>, ICarOptionRepository
    {
        public CarOptionRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task RemoveAllWithCarIdAsync(string carId)
        {
            var carsOptions = await Find(co => co.CarId == carId)
                .ToArrayAsync();

            RemoveRange(carsOptions);
        }
    }
}