namespace MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.SortStrategies.TestDriveStrategies.Interfaces;

    public class SortTestDrivesByPredicateStrategy<TKey> : ITestDriveSortStrategy
    {
        private readonly Expression<Func<TestDrive, TKey>> predicate;

        public SortTestDrivesByPredicateStrategy(Expression<Func<TestDrive, TKey>> predicate)
        {
            this.predicate = predicate;
        }

        public IQueryable<TestDrive> Sort(IQueryable<TestDrive> testDrives)
        {
            var sortedTestDrive = testDrives.OrderBy(this.predicate);

            return sortedTestDrive;
        }
    }
}
