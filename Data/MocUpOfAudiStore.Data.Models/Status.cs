namespace MocUpOfAudiStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MocUpOfAudiStore.Common.Constants;

    public class Status
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(ModelConstatns.TestDriveNameMaxLength)]
        [MinLength(ModelConstatns.TestDriveNameMinLength)]
        public string Name { get; set; }

        public ICollection<TestDrive> TestDrives { get; set; } = new List<TestDrive>();
    }
}
