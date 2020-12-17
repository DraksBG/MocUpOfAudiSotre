namespace MocUpOfAudiStore.Services.FilterStrategies.UserStrategies
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.UserStrategies.Interfaces;

    public class ReturnAllUsersFilterStrategy : IUserFilterStrategy
    {
        public IQueryable<ApplicationUser> Filter(IQueryable<ApplicationUser> users)
        {
            return users;
        }
    }
}
