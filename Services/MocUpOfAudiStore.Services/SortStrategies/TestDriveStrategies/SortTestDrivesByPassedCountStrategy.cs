namespace MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies
{
    using System.Linq;

    using MocUpOfAudiStore.Common.Enums;
    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies.Interfaces;

    public class SortTestDrivesByPassedCountStrategy : ITestDriveSortStrategy
    {
        public IQueryable<TestDrive> Sort(IQueryable<TestDrive> testDrives)
        {
            var sortedTestDrives = testDrives
                .OrderBy(td => td.User.TestDrives
                    .Count(utd => utd.Status.Name == TestDriveStatus.Passed.ToString()));

            return sortedTestDrives;
        }
    }
}
