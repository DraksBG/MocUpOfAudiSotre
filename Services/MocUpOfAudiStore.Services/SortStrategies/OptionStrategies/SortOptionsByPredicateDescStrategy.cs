namespace MocUpOfAudiStore.Services.SortStrategies.OptionStrategies
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.SortStrategies.OptionStrategies.Interfaces;

    public class SortOptionsByPredicateDescStrategy<TKey> : IOptionSortStrategy
    {
        private readonly Expression<Func<Option, TKey>> predicate;

        public SortOptionsByPredicateDescStrategy(Expression<Func<Option, TKey>> predicate)
        {
            this.predicate = predicate;
        }

        public IQueryable<Option> Sort(IQueryable<Option> options)
        {
            var sortedOptions = options.OrderByDescending(this.predicate);

            return sortedOptions;
        }
    }
}
