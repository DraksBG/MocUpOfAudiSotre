using System;
using System.Collections.Generic;
using System.Text;
using MocUpOfAudiStore.Data.Models;
using MocUpOfAudiStore.Services.Mapping;

namespace MocUpOfAudiStore.Services.ModelServices
{
    public class StatusServiceModel : IMapFrom<Status>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
