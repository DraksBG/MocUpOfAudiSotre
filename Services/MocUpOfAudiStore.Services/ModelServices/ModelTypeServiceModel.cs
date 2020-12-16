using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using MocUpOfAudiStore.Data.Models;
using MocUpOfAudiStore.Services.Mapping;

namespace MocUpOfAudiStore.Services.ModelServices
{
    public class ModelTypeServiceModel : IMapTo<SelectListItem>, IMapFrom<ModelType>, IMapTo<ModelType>,
        IHaveCustomMappings
    {
        public string Id { get; set; }

        public int CarsCount { get; set; }

        public string Name { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ModelTypeServiceModel, ModelType>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            configuration.CreateMap<ModelType, ModelTypeServiceModel>()
                .ForMember(dest => dest.CarsCount, opt => opt.MapFrom(src => src.Cars.Count()));

            configuration.CreateMap<ModelTypeServiceModel, SelectListItem>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));
        }
    }
}
