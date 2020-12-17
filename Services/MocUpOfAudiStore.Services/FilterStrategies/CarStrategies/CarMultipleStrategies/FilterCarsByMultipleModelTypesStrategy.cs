namespace MocUpOfAudiStore.Services.FilterStrategies.CarStrategies.CarMultipleStrategies
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.CarStrategies.CarMultipleStrategies.Interfaces;

    public class FilterCarsByMultipleModelTypesStrategy : ICarMultipleFilterStrategy
    {
        private readonly string[] modelTypeNames;

        public FilterCarsByMultipleModelTypesStrategy(params string[] modelTypeNames)
        {
            this.modelTypeNames = modelTypeNames;
        }

        public IQueryable<BaseCar> Filter(IQueryable<BaseCar> cars)
        {
            var sortedCars = cars.Where(c => this.modelTypeNames.Any(mtn => mtn == c.ModelType.Name));

            return sortedCars;
        }
    }
}
