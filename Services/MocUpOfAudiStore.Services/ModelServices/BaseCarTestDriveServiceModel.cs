using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MocUpOfAudiStore.Common.Enums;
using MocUpOfAudiStore.Data.Models;
using MocUpOfAudiStore.Services.Mapping;

namespace MocUpOfAudiStore.Services.ModelServices
{
    public abstract class BaseCarTestDriveServiceModel : BaseCarServiceModel, IMapFrom<BaseCar>, IMapFrom<UsedCar>,
        IMapFrom<NewCar>, IHaveCustomMappings
    {
        public bool IsTestDriveScheduled { get; set; }

        public string TestDriveId { get; set; }

        public override void CreateMappings(IProfileExpression configuration)
        {
            // TODO: Refactor
            var isUserSignedIn = false;
            IEnumerable<string> dbUserTestDriveIds = new List<string>();
            configuration.CreateMap<BaseCar, BaseCarTestDriveServiceModel>()
                .ForMember(dest => dest.TestDriveId, opt => opt.MapFrom(src => isUserSignedIn
                    ? src.TestDrives
                        .Where(
                            td => td.Status.Name == TestDriveStatus.Upcoming.ToString() &&
                                  dbUserTestDriveIds.Any(ids => ids == td.Id))
                        .FirstOrDefault().Id
                    : null
                ))
                .ForMember(dest => dest.IsTestDriveScheduled, opt => opt.MapFrom(src =>
                    isUserSignedIn &&
                    src.TestDrives.Any(td =>
                        td.Status.Name == TestDriveStatus.Upcoming.ToString() &&
                        dbUserTestDriveIds.Any(ids => ids == td.Id)
                    )))
                .IncludeAllDerived();

            base.CreateMappings(configuration);
        }
    }
}
