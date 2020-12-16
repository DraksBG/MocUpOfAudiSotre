using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using MocUpOfAudiStore.Data.Models;
using MocUpOfAudiStore.Services.Mapping;

namespace MocUpOfAudiStore.Services.ModelServices
{
   public class CarOptionServiceModel : IMapFrom<SelectListItem>, IMapTo<CarOption>, IMapFrom<CarOption>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string CarId { get; set; }

        public string OptionId { get; set; }
        public OptionServiceModel Option { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<SelectListItem, CarOptionServiceModel>()
                .ForMember(dest => dest.OptionId, opt => opt.MapFrom(src => src.Value));
        }
    }
}
