using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MocUpOfAudiStore.Common.Enums;
using MocUpOfAudiStore.Data.Models;
using MocUpOfAudiStore.Services.ModelServices;

namespace MocUpOfAudiStore.Services.Interfaces
{
    public interface IHomeService
    {
        Task<HomeSearchServiceModel> GetSearchModelAsync(IQueryable<BaseCar> cars, CarType carType);
    }
}
