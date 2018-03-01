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
        public int JobContactId { get; set; }

        [Required]
        public int JobId { get; set; }
        public Job job { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        public Contact Contact { get; set; }
    }
}
