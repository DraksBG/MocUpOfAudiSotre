// ReSharper disable VirtualMemberCallInConstructor

namespace MocUpOfAudiStore.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using MocUpOfAudiStore.Common.Constants;
    using MocUpOfAudiStore.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        [MaxLength(ModelConstatns.UserNameMaxLength)]
        [MinLength(ModelConstatns.UserNameMinLength)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(ModelConstatns.UserNameMaxLength)]
        [MinLength(ModelConstatns.UserNameMinLength)]
        [Required]
        public string LastName { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public ICollection<TestDrive> TestDrives { get; set; } = new List<TestDrive>();
    }
}
