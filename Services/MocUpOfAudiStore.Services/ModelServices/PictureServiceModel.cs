namespace MocUpOfAudiStore.Services.ModelServices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AutoMapper;
    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.Mapping;

    public class PictureServiceModel : IMapFrom<string>, IMapFrom<Picture>, IMapTo<Picture>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string CarId { get; set; }

        public string PublicId { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<string, PictureServiceModel>()
                .ForMember(dest => dest.PublicId, opt => opt.MapFrom(src => src));

            configuration.CreateMap<PictureServiceModel, Picture>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
