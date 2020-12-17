namespace MocUpOfAudiStore.Services.SortStrategies.OptionStrategies.Interfaces
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;

    public interface IOptionSortStrategy
    {
        IQueryable<Option> Sort(IQueryable<Option> options);
    }
}
