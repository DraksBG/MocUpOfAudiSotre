namespace MocUpOfAudiStore.Services.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.ModelServices;

    public interface ICarTestDriveService
    {
        Task<TModel> GetCarTestDriveModelById<TModel>(string id, ClaimsPrincipal user)
            where TModel : BaseCarTestDriveServiceModel;

        Task<IQueryable<TModel>> GetCarTestDriveModelAsync<TModel>(
            IQueryable<BaseCar> cars,
            ClaimsPrincipal user,
            int pageNumber) where TModel : BaseCarTestDriveServiceModel;
    }
}
