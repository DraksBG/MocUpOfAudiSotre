namespace MocUpOfAudiStore.Services.SortStrategies.CarsStrategies
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.SortStrategies.CarsStrategies.Interfaces;

    public class SortCarsByPredicateStrategy<TCar, TKey> : ICarSortStrategy<TCar> where TCar : BaseCar
    {
        private readonly Expression<Func<TCar, TKey>> predicate;

        public SortCarsByPredicateStrategy(Expression<Func<TCar, TKey>> predicate)
        {
            this.predicate = predicate;
        }

        public IQueryable<TCar> Sort(IQueryable<TCar> cars)
        {
            var sortedCars = cars.OrderBy(this.predicate);

            return sortedCars;
        }
    }
}
