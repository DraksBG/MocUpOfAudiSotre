namespace MocUpOfAudiStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MocUpOfAudiStore.Common.Constants;

    public class Option
    {
        public string Id { get; set; }

        public ICollection<CarOption> CarsOptions { get; set; } = new List<CarOption>();

        [MaxLength(ModelConstatns.OptionNameMaxLength)]
        [MinLength(ModelConstatns.OptionNameMinLength)]
        [Required]
        public string Name { get; set; }

        [Range(typeof(decimal), ModelConstatns.MinPrice, ModelConstatns.OptionNameMaxPrice)]
        [Required]
        public decimal Price { get; set; }

        [Required]
        public string OptionTypeId { get; set; }

        public OptionType OptionType { get; set; }

    }
}
