namespace MocUpOfAudiStore.Services.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.CarStrategies.Interfaces;
    using MocUpOfAudiStore.Services.ModelServices;
    using MocUpOfAudiStore.Services.SortStrategies.CarsStrategies.Interfaces;

    public interface ICarsService
    {
        IQueryable<BaseCarServiceModel> GetCars(
            ICarSortStrategy<BaseCar> sortStrategy,
            params ICarFilterStrategy[] filterStrategies);
        Task<CarServiceModel> GetByIdAsync(string carId);
        IQueryable<TCar> GetFiltered<TCar>(params ICarFilterStrategy[] filterStrategies)
            where TCar : BaseCar;
    }
}
