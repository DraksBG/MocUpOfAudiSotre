namespace MocUpOfAudiStore.Services.FilterStrategies.OptionStrategies.Interfaces
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;

    public interface IOptionFilterStrategy
    {
        IQueryable<Option> Filter(IQueryable<Option> options);
    }
}
