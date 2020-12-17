namespace MocUpOfAudiStore.Data.Interfaces
{
    using System.Threading.Tasks;
    using MocUpOfAudiStore.Data.Models;

   public  interface ICarOptionRepository : IRepository<CarOption>
    {
        Task RemoveAllWithCarIdAsync(string carId);
    }
}
