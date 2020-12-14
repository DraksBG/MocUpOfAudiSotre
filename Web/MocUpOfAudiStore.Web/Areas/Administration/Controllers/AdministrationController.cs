namespace MocUpOfAudiStore.Web.Areas.Administration.Controllers
{
    using MocUpOfAudiStore.Common;
    using MocUpOfAudiStore.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
