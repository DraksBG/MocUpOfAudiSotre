namespace MocUpOfAudiStore.Services.SortStrategies.CarsStrategies.Interfaces
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;

    public interface ICarSortStrategy<TCar> where TCar : BaseCar
    {
        IQueryable<TCar> Sort(IQueryable<TCar> cars);
    }
}
