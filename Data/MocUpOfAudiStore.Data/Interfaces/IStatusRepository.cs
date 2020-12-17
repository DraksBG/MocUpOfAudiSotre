namespace MocUpOfAudiStore.Data.Interfaces
{
    using System.Threading.Tasks;

    using MocUpOfAudiStore.Data.Common.Repositories;
    using Models;

    public interface IStatusRepository : IRepository<Status>
    {
        Task<string> GetIdByNameAsync(string name);
    }
}