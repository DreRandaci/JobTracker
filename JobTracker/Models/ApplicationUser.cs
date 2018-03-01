using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace JobTracker.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(55, ErrorMessage = "Sorry, that's too long. Please enter your nickname")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(55, ErrorMessage = "Sorry, that's too long")]
        public string LastName { get; set; }

        public virtual ICollection<Job> SavedJobs { get; set; }

        public virtual ICollection<Job> AppliedJobs { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
