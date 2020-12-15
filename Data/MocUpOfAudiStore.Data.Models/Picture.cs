namespace MocUpOfAudiStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Picture
    {
        public string Id { get; set; }

        [Required] public string CarId { get; set; }

        public BaseCar Car { get; set; }

        [Required] public string PublicId { get; set; }
    }
}
