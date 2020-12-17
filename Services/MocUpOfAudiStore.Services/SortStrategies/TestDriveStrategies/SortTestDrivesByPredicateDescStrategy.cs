namespace MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies.Interfaces;

    public class SortTestDrivesByPredicateDescStrategy<TKey> : ITestDriveSortStrategy
    {
        private readonly Expression<Func<TestDrive, TKey>> predicate;

        public SortTestDrivesByPredicateDescStrategy(Expression<Func<TestDrive, TKey>> predicate)
        {
            this.predicate = predicate;
        }

        public IQueryable<TestDrive> Sort(IQueryable<TestDrive> testDrives)
        {
            var sortedTestDrives = testDrives.OrderByDescending(this.predicate);

            return sortedTestDrives;
        }
    }
}
