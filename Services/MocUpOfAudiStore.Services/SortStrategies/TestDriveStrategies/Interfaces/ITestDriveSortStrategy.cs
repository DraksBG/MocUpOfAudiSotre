namespace MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies.Interfaces
{
    using System.Linq;

    using MocUpOfAudiStore.Data.Models;

    public interface ITestDriveSortStrategy
    {
        IQueryable<TestDrive> Sort(IQueryable<TestDrive> testDrives);
    }
}
