namespace MocUpOfAudiStore.Services.FilterStrategies.TestDrives
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.TestDrives.Interfaces;

    public class ReturnAllTestDrivesFilterStrategy : ITestDriveFilterStrategy
    {
        public IQueryable<TestDrive> Filter(IQueryable<TestDrive> testDrives)
        {
            return testDrives;
        }
    }
}
