namespace MocUpOfAudiStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MocUpOfAudiStore.Common.Constants;

    public abstract class BaseCar
    {
        public string Id { get; set; }

        [Range(ModelConstatns.CarMinAcceleration_0_100Km, ModelConstatns.CarMaxAcceleration_0_100Km)]
        [Required]
        public double Acceleration_0_100Km { get; set; }

        [Range(ModelConstatns.CarMinCO2Emissions, ModelConstatns.CarMaxCO2Emissions)]
        [Required]
        public int CO2Emissions { get; set; }

        [Required]
        public string ColorName { get; set; }

        [MinLength(ModelConstatns.CarDescriptionMinLength)]
        [MaxLength(ModelConstatns.CarDescriptionMaxLength)]
        [Required]
        public string Description { get; set; }

        [Range(ModelConstatns.CarMinDisplacement, ModelConstatns.CarMaxDisplacement)]
        [Required]
        public double Displacement { get; set; }

        [Range(ModelConstatns.CarMinDoorsCount, ModelConstatns.CarMaxDoorsCount)]
        [Required]
        public int DoorsCount { get; set; }

        [Required]
        public string EngineId { get; set; }

        public Engine Engine { get; set; }

        [Range(ModelConstatns.CarMinFuelConsumation, ModelConstatns.CarMaxFuelConsumation_City_Litres_100Km)]
        [Required]
        public double FuelConsumation_City_Litres_100Km { get; set; }

        [Range(ModelConstatns.CarMinFuelConsumation, ModelConstatns.CarMaxFuelConsumation_Highway_Litres_100Km)]
        [Required]
        public double FuelConsumation_Highway_Litres_100Km { get; set; }

        [Required]
        public string FuelTypeId { get; set; }

        public FuelType FuelType { get; set; }

        [Range(ModelConstatns.CarMinHoursePower, ModelConstatns.CarMaxHoursePower)]
        [Required]
        public double HoursePower { get; set; }

        [Required]
        public string ModelTypeId { get; set; }

        public ModelType ModelType { get; set; }

        [MaxLength(ModelConstatns.CarNameMaxLength)]
        [MinLength(ModelConstatns.CarNameMinLength)]
        [Required]
        public string Name { get; set; }

        public ICollection<CarOption> Options { get; set; } = new List<CarOption>();

        public ICollection<Picture> Pictures { get; set; } = new List<Picture>();

        [Range(typeof(decimal), ModelConstatns.MinPrice, ModelConstatns.CarMaxPrice)]
        [Required]
        public decimal Price { get; set; }

        [Required]
        public string SeriesId { get; set; }

        public Series Series { get; set; }

        [Range(ModelConstatns.CarMinTorque, ModelConstatns.CarMaxTorque)]
        [Required]
        public decimal Torque { get; set; }

        public ICollection<TestDrive> TestDrives { get; set; } = new List<TestDrive>();

        [MaxLength(ModelConstatns.CarVinLength)]
        [MinLength(ModelConstatns.CarVinLength)]
        [Required]
        public string Vin { get; set; }

        [Range(ModelConstatns.CarMinWarrantyMonthsLeft, ModelConstatns.CarMaxWarrantyMonthsLeft)]
        [Required]
        public int WarrantyMonthsLeft { get; set; }

        [Range(ModelConstatns.CarMinWeight, ModelConstatns.CarMaxWeight)]
        [Required]
        public int Weight_Kg { get; set; }

        [MinLength(4)]
        public string Year { get; set; }
    }
}
