namespace MocUpOfAudiStore.Data.Repositories
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using MocUpOfAudiStore.Data.Interfaces;
    using Models;

    public class CarRepository : BaseRepository<BaseCar>, ICarRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CarRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> IsType(Type type, string carId)
        {
            var isType = await GetAll().AnyAsync(c => c is NewCar && c.Id == carId);

            return isType;
        }

        public DbSet<TCar> Set<TCar>() where TCar : BaseCar
        {
            return dbContext.Set<TCar>();
        }
    }
}