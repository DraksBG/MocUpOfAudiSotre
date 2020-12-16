using System;
using System.Collections.Generic;
using System.Text;
using MocUpOfAudiStore.Data.Models;
using MocUpOfAudiStore.Services.Mapping;

namespace MocUpOfAudiStore.Services.ModelServices
{
    public class ScheduleTestDriveServiceModel : IMapTo<TestDrive>
    {
        public string CarId { get; set; }

        public DateTime ScheduleDate { get; set; }

        public string Comment { get; set; }
    }
}
