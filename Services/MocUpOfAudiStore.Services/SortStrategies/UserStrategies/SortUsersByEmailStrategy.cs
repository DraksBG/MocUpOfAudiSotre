namespace MocUpOfAudiStore.Services.SortStrategies.UserStrategies
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.SortStrategies.UserStrategies.Interfaces;

    public class SortUsersByEmailStrategy : IUserSortStrategy
    {
        public IQueryable<ApplicationUser> Sort(IQueryable<ApplicationUser> users)
        {
            var sortedUsers = users.OrderBy(u => u.NormalizedEmail);

            return sortedUsers;
        }
    }
}
