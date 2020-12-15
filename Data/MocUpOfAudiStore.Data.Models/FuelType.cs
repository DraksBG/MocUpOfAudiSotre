﻿namespace MocUpOfAudiStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MocUpOfAudiStore.Common.Constants;

    public class FuelType
    {
        public string Id { get; set; }

        public ICollection<BaseCar> Cars { get; set; } = new List<BaseCar>();

        [MaxLength(ModelConstatns.FuelTypeNameMaxLength)]
        [MinLength(ModelConstatns.FuelTypeNameMinLength)]
        [Required]
        public string Name { get; set; }
    }
}
