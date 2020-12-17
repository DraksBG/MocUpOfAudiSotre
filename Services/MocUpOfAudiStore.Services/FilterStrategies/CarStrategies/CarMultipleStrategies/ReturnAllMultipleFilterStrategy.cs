namespace MocUpOfAudiStore.Services.FilterStrategies.CarStrategies.CarMultipleStrategies
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.CarStrategies.CarMultipleStrategies.Interfaces;

    public class ReturnAllMultipleFilterStrategy : ICarMultipleFilterStrategy
    {
        public IQueryable<BaseCar> Filter(IQueryable<BaseCar> cars)
        {
            return cars;
        }
    }
}
