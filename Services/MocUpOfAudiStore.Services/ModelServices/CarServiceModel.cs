namespace MocUpOfAudiStore.Services.ModelServices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AutoMapper;
    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.Mapping;

    public class CarServiceModel : BaseCarTestDriveServiceModel, IMapTo<BaseCar>, IMapTo<UsedCar>, IMapFrom<BaseCar>,
        IHaveCustomMappings
    {
        public double Acceleration_0_100Km { get; set; }

        public int CO2Emissions { get; set; }

        public string ColorName { get; set; }

        public string Description { get; set; }

        public double Displacement { get; set; }

        public int DoorsCount { get; set; }

        public string EngineId { get; set; }
        public string EngineName { get; set; }

        public double FuelConsumation_City_Litres_100Km { get; set; }

        public double FuelConsumation_Highway_Litres_100Km { get; set; }

        public string FuelTypeId { get; set; }

        public ModelTypeServiceModel ModelType { get; set; }

        public ICollection<CarOptionServiceModel> Options { get; set; } = new List<CarOptionServiceModel>();

        public ICollection<PictureServiceModel> Pictures { get; set; } = new List<PictureServiceModel>();

        public EngineServiceModel Engine { get; set; }

        public string SeriesId { get; set; }

        public decimal Torque { get; set; }

        public int Weight_Kg { get; set; }

        public override void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<CarServiceModel, UsedCar>()
                .ForMember(dest => dest.Pictures, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            configuration.CreateMap<CarServiceModel, NewCar>()
                .ForMember(dest => dest.Pictures, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            configuration.CreateMap<BaseCar, CarServiceModel>()
                .ForMember(dest => dest.CarType, opt => opt.MapFrom(src => src.GetType()))
                .ForMember(dest => dest.Mileage,
                    opt => opt.MapFrom(src => src is UsedCar ? (src as UsedCar).Mileage : 0));

            base.CreateMappings(configuration);
        }
    }
}
