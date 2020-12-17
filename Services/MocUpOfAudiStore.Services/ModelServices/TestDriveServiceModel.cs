namespace MocUpOfAudiStore.Services.ModelServices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.Mapping;

    public class TestDriveServiceModel : IMapFrom<TestDrive>
    {
        public string Id { get; set; }
        public string CarId { get; set; }
        public BaseCarServiceModel Car { get; set; }

        public string UserId { get; set; }
        public UserConciseServiceModel User { get; set; }

        public string StatusId { get; set; }
        public StatusServiceModel Status { get; set; }

        public DateTime ScheduleDate { get; set; }

        public string Comment { get; set; }
    }
}
