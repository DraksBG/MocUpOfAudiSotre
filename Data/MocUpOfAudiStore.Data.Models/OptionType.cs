namespace MocUpOfAudiStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MocUpOfAudiStore.Common.Constants;

    public class OptionType
    {
        public string Id { get; set; }

        [MaxLength(ModelConstatns.OptionTypeNameMaxLength)]
        [MinLength(ModelConstatns.OptionTypeNameMinLength)]
        [Required]
        public string Name { get; set; }

        public ICollection<Option> Options { get; set; } = new List<Option>();
    }
}
