namespace MocUpOfAudiStore.Data.Interfaces
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using MocUpOfAudiStore.Data.Common.Repositories;
    using MocUpOfAudiStore.Data.Models;

    public interface ICarRepository : IRepository<BaseCar>
    {
        Task<bool> IsType(Type type, string carId);

        DbSet<TCar> Set<TCar>() where TCar : BaseCar;
    }
}
