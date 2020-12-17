namespace MocUpOfAudiStore.Services.FilterStrategies.OptionStrategies
{
    using System;
    using System.Linq;

    using MocUpOfAudiStore.Common.Constants;
    using MocUpOfAudiStore.Common.Validation;
    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.OptionStrategies.Interfaces;

    public class FilterOptionsByOptionTypeNameStrategy : IOptionFilterStrategy
    {
        private readonly string optionTypeName;

        public FilterOptionsByOptionTypeNameStrategy(string optionTypeName)
        {
            var exception = new ArgumentException(ErrorConstants.CantBeNullOrEmptyParameter, nameof(optionTypeName));
            DataValidator.ValidateNotNullOrEmpty(optionTypeName, exception);

            this.optionTypeName = optionTypeName;
        }

        public IQueryable<Option> Filter(IQueryable<Option> options)
        {
            var filteredOptions = options.Where(o => o.OptionType.Name == optionTypeName);

            return filteredOptions;
        }
    }
}
