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
    public class SeriesServiceModel : IMapTo<SelectListItem>, IMapFrom<Series>, IMapTo<Series>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public int CarsCount { get; set; }

        public string Name { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Series, SeriesServiceModel>()
                .ForMember(dest => dest.CarsCount, opt => opt.MapFrom(src => src.Cars.Count()));

            configuration.CreateMap<SeriesServiceModel, Series>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            configuration.CreateMap<SeriesServiceModel, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));
        }
    }
}
