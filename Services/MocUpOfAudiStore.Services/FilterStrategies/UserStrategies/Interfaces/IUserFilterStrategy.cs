namespace MocUpOfAudiStore.Services.FilterStrategies.UserStrategies.Interfaces
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;

    public interface IUserFilterStrategy
    {
        IQueryable<ApplicationUser> Filter(IQueryable<ApplicationUser> users);
    }
}
