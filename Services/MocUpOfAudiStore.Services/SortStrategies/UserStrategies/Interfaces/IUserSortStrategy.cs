
namespace MocUpOfAudiStore.Services.SortStrategies.UserStrategies.Interfaces
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;

    public interface IUserSortStrategy
    {
        IQueryable<ApplicationUser> Sort(IQueryable<ApplicationUser> users);
    }
}
