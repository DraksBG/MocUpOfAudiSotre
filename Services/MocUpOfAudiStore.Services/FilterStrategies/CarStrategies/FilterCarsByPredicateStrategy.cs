namespace MocUpOfAudiStore.Services.FilterStrategies.CarStrategies
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.CarStrategies.Interfaces;

    public class FilterCarsByPredicateStrategy : ICarFilterStrategy
    {
        private readonly Expression<Func<BaseCar, bool>> predicate;

        public FilterCarsByPredicateStrategy(Expression<Func<BaseCar, bool>> predicate)
        {
            this.predicate = predicate;
        }

        public IQueryable<BaseCar> Filter(IQueryable<BaseCar> cars)
        {
            var filteredCars = cars.Where(predicate);

            return filteredCars;
        }
    }
}
