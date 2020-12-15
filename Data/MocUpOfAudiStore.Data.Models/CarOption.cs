namespace MocUpOfAudiStore.Data.Models
{
    public class CarOption
    {
        public string Id { get; set; }

        public string CarId { get; set; }

        public BaseCar Car { get; set; }

        public string OptionId { get; set; }

        public Option Option { get; set; }

    }
}
