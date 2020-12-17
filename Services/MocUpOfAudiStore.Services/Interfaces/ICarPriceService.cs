namespace MocUpOfAudiStore.Services.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MocUpOfAudiStore.Data.Models;
    using MocUpOfAudiStore.Services.ModelServices;

    public interface ICarPriceService
    {
        Task<ICollection<FilterTypeServiceModel>> GetPriceFilterModelsAsync(IQueryable<BaseCar> cars);
    }
}
