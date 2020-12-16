namespace MocUpOfAudiStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MocUpOfAudiStore.Common.Constants;

    public class Transmission
    {
        public string Id { get; set; }

        public ICollection<Engine> Engines { get; set; } = new List<Engine>();

        [MaxLength(ModelConstatns.TransmissionNameMaxLength)]
        [MinLength(ModelConstatns.TransmissionNameMinLength)]
        [Required]
        public string Name { get; set; }

        [Range(typeof(decimal), ModelConstatns.MinPrice, ModelConstatns.TransmissionMaxPrice)]
        [Required]
        public decimal Price { get; set; }
    }
}
