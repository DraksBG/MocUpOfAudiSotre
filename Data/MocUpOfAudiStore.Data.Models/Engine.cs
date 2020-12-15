namespace MocUpOfAudiStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using MocUpOfAudiStore.Common.Constants;
    using MocUpOfAudiStore.Services.Mapping;

    public class Engine : IMapTo<SelectListItem>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public ICollection<BaseCar> Cars { get; set; } = new List<BaseCar>();

        [MaxLength(ModelConstatns.EngineeNameMaxLength)]
        [MinLength(ModelConstatns.EngineNameMinLength)]
        [Required]
        public string Name { get; set; }

        [Range(typeof(decimal), ModelConstatns.MinPrice, ModelConstatns.EngineMaxPrice)]
        [Required]
        public decimal Price { get; set; }

        [Required]
        public string TransmissionId { get; set; }

        public Transmission Transmission { get; set; }

        [Range(ModelConstatns.EngineMinWeight_Kg, ModelConstatns.EngineMaxWeight_Kg)]
        [Required]
        public int Weight_Kg { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Engine, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name));
        }
    }
}
