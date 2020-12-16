namespace MocUpOfAudiStore.Data.Interfaces
{
    using System.Threading.Tasks;

    using MocUpOfAudiStore.Data.Common.Repositories;
    using MocUpOfAudiStore.Data.Models;

   public  interface ICarOptionRepository : IRepository<CarOption>
    {
        Task RemoveAllWithCarIdAsync(string carId);
    }
}
