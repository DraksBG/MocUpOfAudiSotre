namespace MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies
{
    using System.Linq;

    using MocUpOfAudiStore.Common.Enums;
    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies.Interfaces;

    public class SortTestDrivesByStatusStrategy : ITestDriveSortStrategy
    {
        public IQueryable<TestDrive> Sort(IQueryable<TestDrive> testDrives)
        {
            var sortedTestDrives = testDrives
                .OrderBy(td => td.Status.Name == TestDriveStatus.Upcoming.ToString() ? 0 : 1)
                .ThenBy(td => td.Status.Name == TestDriveStatus.Passed.ToString() ? 0 : 1);

            return sortedTestDrives;
        }
    }
}
