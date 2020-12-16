namespace MocUpOfAudiStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using MocUpOfAudiStore.Common.Constants;

    public class UsedCar : BaseCar
    {
        [Range(ModelConstatns.CarMinMileage, ModelConstatns.CarMaxMileage)]
        [Required]
        public double Mileage { get; set; }
    }
}
