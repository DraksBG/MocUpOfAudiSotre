namespace MocUpOfAudiStore.Services.ModelServices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.Mapping;

    public class UserServiceModel : IMapTo<ApplicationUser>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }
    }
}
