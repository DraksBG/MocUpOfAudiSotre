namespace MocUpOfAudiStore.Services.FilterStrategies.OptionStrategies
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.OptionStrategies.Interfaces;

    public class ReturnAllFilterStrategy : IOptionFilterStrategy
    {
        public IQueryable<Option> Filter(IQueryable<Option> options)
        {
            return options;
        }
    }
}
