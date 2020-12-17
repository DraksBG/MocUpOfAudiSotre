namespace MocUpOfAudiStore.Services.FilterStrategies.CarStrategies.CarMultipleStrategies.Interfaces
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;

    public interface ICarMultipleFilterStrategy
    {
        IQueryable<BaseCar> Filter(IQueryable<BaseCar> cars);
    }
}
