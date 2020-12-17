namespace MocUpOfAudiStore.Services.ModelServices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MocUpOfAudiStore.Common.Constants;
    using MocUpOfAudiStore.Common.Enums;

    public class HomeSearchServiceModel
    {
        public CarType SelectedCarType { get; set; } = CarType.NewCar;
        public IEnumerable<FilterTypeServiceModel> CarTypes { get; set; } = new List<FilterTypeServiceModel>();

        public string SelectedYear { get; set; } = WebConstants.AllFilterTypeModelValue;
        public IEnumerable<FilterTypeServiceModel> Years { get; set; } = new List<FilterTypeServiceModel>();

        public string SelectedModelType { get; set; } = WebConstants.AllFilterTypeModelValue;
        public IEnumerable<FilterTypeServiceModel> ModelTypes { get; set; } = new List<FilterTypeServiceModel>();

        public string SelectedPriceRange { get; set; } = WebConstants.AllFilterTypeModelValue;
        public IEnumerable<FilterTypeServiceModel> PriceRanges { get; set; } = new List<FilterTypeServiceModel>();
    }
}
