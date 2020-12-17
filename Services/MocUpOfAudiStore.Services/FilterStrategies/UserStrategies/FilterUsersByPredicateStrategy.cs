namespace MocUpOfAudiStore.Services.FilterStrategies.UserStrategies
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.UserStrategies.Interfaces;

    public class FilterUsersByPredicateStrategy : IUserFilterStrategy
    {
        private readonly Expression<Func<ApplicationUser, bool>> predicate;

        public FilterUsersByPredicateStrategy(Expression<Func<ApplicationUser, bool>> predicate)
        {
            this.predicate = predicate;
        }

        public IQueryable<ApplicationUser> Filter(IQueryable<ApplicationUser> users)
        {
            var filteredUsers = users.Where(predicate);

            return filteredUsers;
        }
    }
}
