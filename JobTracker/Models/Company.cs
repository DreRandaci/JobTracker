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
        public string CompanyName { get; set; }

        [Required]
        public int ApiId { get; set; }

        [Required]
        public string CompanyLogoUrl { get; set; }

        [Required]
        public string CompanyUrl { get; set; }

    }
}
