namespace MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies
{
    using System.Linq;

    using MocUpOfAudiStore.Common.Enums;
    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies.Interfaces;

    public class SortTestDrivesByPassedCountDescStrategy : ITestDriveSortStrategy
    {
        public IQueryable<TestDrive> Sort(IQueryable<TestDrive> testDrives)
        {
            var sortedTestDrives = testDrives
                .OrderByDescending(td => td.User.TestDrives
                    .Count(utd => utd.Status.Name == TestDriveStatus.Passed.ToString()));

            return sortedTestDrives;
        }
    }
}
