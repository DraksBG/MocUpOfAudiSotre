namespace MocUpOfAudiStore.Services.FilterStrategies.CarStrategies
{
    using System;
    using System.Linq;

    using MocUpOfAudiStore.Common.Constants;
    using MocUpOfAudiStore.Common.Validation;
    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.FilterStrategies.CarStrategies.Interfaces;

    public class FilterCarsByKeyWordStrategy : ICarFilterStrategy
    {
        private readonly string keyWord;

        public FilterCarsByKeyWordStrategy(string keyWord)
        {
            var exception = new ArgumentException(ErrorConstants.CantBeNullOrEmptyParameter, nameof(keyWord));
            DataValidator.ValidateNotNullOrEmpty(keyWord, exception);

            this.keyWord = keyWord.ToLower();
        }

        public IQueryable<BaseCar> Filter(IQueryable<BaseCar> cars)
        {
            var filteredCars = cars.Where(c =>
                c.Name.ToLower().Contains(this.keyWord)
                ||
                c.Series.Name.ToLower() == this.keyWord
                ||
                c.GetType().Name.ToLower().Contains(this.keyWord)
                ||
                c.ModelType.Name.ToLower().Contains(this.keyWord)
                ||
                c.Year == this.keyWord
                ||
                c.ColorName.ToLower() == this.keyWord
            );

            return filteredCars;
        }
    }
}
