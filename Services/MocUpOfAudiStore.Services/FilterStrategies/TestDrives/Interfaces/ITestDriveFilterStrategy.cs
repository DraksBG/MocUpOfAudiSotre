namespace MocUpOfAudiStore.Services.FilterStrategies.TestDrives.Interfaces
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;

    public interface ITestDriveFilterStrategy
    {
        IQueryable<TestDrive> Filter(IQueryable<TestDrive> testDrives);
    }
}
