namespace MocUpOfAudiStore.Data.Repositories
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class CarOptionRepository : BaseRepository<CarOption>, ICarOptionRepository
    {
        public CarOptionRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }

        public async Task RemoveAllWithCarIdAsync(string carId)
        {
            var carsOptions = await this.Find(co => co.CarId == carId)
                .ToArrayAsync();

            this.RemoveRange(carsOptions);
        }
    }
}
