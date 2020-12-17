namespace MocUpOfAudiStore.Services.FilterStrategies.CarStrategies
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.CarStrategies.Interfaces;

    public class ReturnAllFilterStrategy : ICarFilterStrategy
    {
        public IQueryable<BaseCar> Filter(IQueryable<BaseCar> cars)
        {
            return cars;
        }
    }
}
