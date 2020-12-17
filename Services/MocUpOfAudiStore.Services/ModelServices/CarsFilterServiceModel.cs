namespace MocUpOfAudiStore.Services.ModelServices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CarsFilterServiceModel
    {
        public List<FilterTypeServiceModel> Years { get; set; } = new List<FilterTypeServiceModel>();

        public List<FilterTypeServiceModel> Series { get; set; } = new List<FilterTypeServiceModel>();

        public List<FilterTypeServiceModel> ModelTypes { get; set; } = new List<FilterTypeServiceModel>();

        public List<FilterTypeServiceModel> Prices { get; set; } = new List<FilterTypeServiceModel>();
    }
}
