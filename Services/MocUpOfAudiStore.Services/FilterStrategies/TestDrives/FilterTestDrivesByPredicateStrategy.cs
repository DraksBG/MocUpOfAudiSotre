namespace MocUpOfAudiStore.Services.FilterStrategies.TestDrives
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.TestDrives.Interfaces;

    public class FilterTestDrivesByPredicateStrategy : ITestDriveFilterStrategy
    {
        private readonly Expression<Func<TestDrive, bool>> predicate;

        public FilterTestDrivesByPredicateStrategy(Expression<Func<TestDrive, bool>> predicate)
        {
            this.predicate = predicate;
        }

        public IQueryable<TestDrive> Filter(IQueryable<TestDrive> testDrives)
        {
            var filteredTestDrives = testDrives.Where(predicate);

            return filteredTestDrives;
        }
    }
}
