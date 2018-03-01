using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class JobContact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [Required]
        public int JobId { get; set; }
        public Job job { get; set; }
    }
}
