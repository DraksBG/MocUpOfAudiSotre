namespace MocUpOfAudiStore.Services.SortStrategies.EngineStrategies.Interfaces
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;

    public interface IEngineSortStrategy
    {
        IQueryable<Engine> Sort(IQueryable<Engine> engines);
    }
}
