namespace MocUpOfAudiStore.Services.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    using MocUpOfAudiStore.Services.ModelServices;

    public interface ITestDriveService
    {
        Task CancelTestDriveAsync(string testDriveId, ClaimsPrincipal user);
        IQueryable<TestDriveServiceModel> GetAll(ClaimsPrincipal user);
        Task<TestDriveServiceModel> GetByIdAsync(string testDriveId, ClaimsPrincipal user);
        Task<string> ScheduleTestDriveAsync(ScheduleTestDriveServiceModel model, ClaimsPrincipal user);
    }   
}
