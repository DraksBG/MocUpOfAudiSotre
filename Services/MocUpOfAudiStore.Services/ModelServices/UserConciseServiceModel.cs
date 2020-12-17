namespace MocUpOfAudiStore.Services.ModelServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using AutoMapper;
    using Microsoft.AspNetCore.Identity;
    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.Mapping;

    public class UserConciseServiceModel : IdentityUser, IMapFrom<ApplicationUser>, IHaveCustomMappings
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int TestDrivesCount { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ApplicationUser, UserConciseServiceModel>()
                .ForMember(dest => dest.TestDrivesCount, opt => opt.MapFrom(src => src.TestDrives.Count()));
        }
    }
}
