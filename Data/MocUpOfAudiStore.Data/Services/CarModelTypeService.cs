using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MocUpOfAudiStore.Data.Models;
using MocUpOfAudiStore.Services.Interfaces;
using MocUpOfAudiStore.Services.ModelServices;

namespace MocUpOfAudiStore.Data.Services
{
    public class CarModelTypeService : ICarModelTypeService
    {
        public async Task<ICollection<FilterTypeServiceModel>> GetModelTypeFilterModelsAsync(IQueryable<BaseCar> cars)
        {
            var modelTypeModels = await cars
                .GroupBy(c => new { Name = c.ModelType.Name })
                .Select(c => new FilterTypeServiceModel()
                {
                    Value = c.Key.Name,
                    Text = c.Key.Name,
                    CarsCount = c.Count()
                })
                .ToListAsync();

            return modelTypeModels;
        }
    }
}
