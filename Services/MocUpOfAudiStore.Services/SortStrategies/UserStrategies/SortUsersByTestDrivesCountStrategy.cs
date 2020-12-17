namespace MocUpOfAudiStore.Services.SortStrategies.UserStrategies
{
    using System.Linq;

    using Microsoft.EntityFrameworkCore;
    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.SortStrategies.UserStrategies.Interfaces;

    public class SortUsersByTestDrivesCountStrategy : IUserSortStrategy
    {
        public IQueryable<ApplicationUser> Sort(IQueryable<ApplicationUser> users)
        {
            var sortedUsers = users
                .Include(u => u.TestDrives)
                .OrderBy(u => u.TestDrives.Count);

            return sortedUsers;
        }
    }
}
