namespace MocUpOfAudiStore.Services.SortStrategies.EngineStrategies
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.SortStrategies.EngineStrategies.Interfaces;

    public class SortEnginesStrategy<TKey> : IEngineSortStrategy
    {
        private readonly Expression<Func<Engine, TKey>> predicate;

        public SortEnginesStrategy(Expression<Func<Engine, TKey>> predicate)
        {
            this.predicate = predicate;
        }

        public IQueryable<Engine> Sort(IQueryable<Engine> engines)
        {
            var sortedEngines = engines.OrderBy(predicate);

            return sortedEngines;
        }
    }
}
