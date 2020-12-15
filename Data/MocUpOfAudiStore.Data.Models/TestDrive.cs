namespace MocUpOfAudiStore.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MocUpOfAudiStore.Common.Constants;

    public class TestDrive
    {
        public string Id { get; set; }

        [Required]
        public string CarId { get; set; }

        public BaseCar Car { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public string StatusId { get; set; }

        public Status Status { get; set; }

        [Required]
        public DateTime ScheduleDate { get; set; }

        [MinLength(ModelConstatns.CommentCommentMinLength)]
        [MaxLength(ModelConstatns.CommentCommentMaxLength)]
        public string Comment { get; set; }
    }
}
