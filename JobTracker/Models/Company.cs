using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [Display(Name = "Company")]
        public string CompanyName { get; set; }            

        [Required]
        public string CompanyUrl { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
