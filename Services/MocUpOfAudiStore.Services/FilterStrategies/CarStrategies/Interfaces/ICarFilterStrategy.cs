namespace MocUpOfAudiStore.Services.FilterStrategies.CarStrategies.Interfaces
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;

    public interface ICarFilterStrategy
    {
        IQueryable<BaseCar> Filter(IQueryable<BaseCar> cars);
    }
}
