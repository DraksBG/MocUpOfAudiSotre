namespace MocUpOfAudiStore.Common.Validation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;

    using Microsoft.AspNetCore.Identity;
    using MocUpOfAudiStore.Common.Constants;

    public class DataValidator
    {
        public static void ValidateMinDateTime(DateTime dateTimeToValidate, DateTime minDateTime)
        {
            if (dateTimeToValidate < minDateTime)
            {
                throw new InvalidOperationException(ErrorConstants.InvalidDateTime);
            }
        }

        public static void ValidateNotNull(object obj, Exception exception)
        {
            if (obj == null)
            {
                throw exception;
            }
        }

        public static void ValidateNotNullOrEmpty(string str, Exception exception)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw exception;
            }
        }

        public static void ValidateNotEmptyCollection(IEnumerable enumerable, string exceptionMessage)
        {
            if (enumerable.GetEnumerator().MoveNext() == false)
            {
                throw new InvalidOperationException(exceptionMessage);
            }
        }

        public static void ValidateEnumType(Type type)
        {
            if (type.IsEnum == false)
            {
                throw new ArgumentException(ErrorConstants.TypeWasNotEnum);
            }
        }

        public static void ValidateNotEmptyEnum(Type enumType, string exceptionMessage)
        {
            var enumValues = Enum.GetValues(enumType);
            ValidateNotEmptyCollection(enumValues, exceptionMessage);
        }

        public static void ValidateEnumValue(string enumValue, Type enumType)
        {
            var result = new object();
            if (Enum.TryParse(enumType, enumValue, out result) == false)
            {
                throw new ArgumentException(ErrorConstants.IncorrectEnumValue);
            }
        }

        public static void ValidateYearString(string year)
        {
            var result = DateTime.UtcNow;
            var isSuccessful = DateTime.ParseExact(year, "yyyy", CultureInfo.InvariantCulture);
        }

        public static void ValidateMinPrice(decimal price, string minPrice)
        {
            if (price < decimal.Parse(minPrice))
            {
                throw new Exception(ErrorConstants.IncorrectPriceRange);
            }
        }

        public static void ValidateMaxPrice(decimal price, string maxPrice)
        {
            if (price > decimal.Parse(maxPrice))
            {
                throw new Exception(ErrorConstants.IncorrectPriceRange);
            }
        }

        public static void ValidateIdentityResult(IdentityResult identityResult)
        {
            if (identityResult.Succeeded)
            {
                return;
            }

            var exceptions = new List<Exception>();

            foreach (var identityError in identityResult.Errors)
            {
                var currentExceptionMessage = $"${identityError.Description}. Error code: { identityError.Code}";
                var currentException = new InvalidOperationException(currentExceptionMessage);

                exceptions.Add(currentException);
            }

            var exceptionsAggregate = new AggregateException(exceptions);
            throw exceptionsAggregate;
        }
    }
}
