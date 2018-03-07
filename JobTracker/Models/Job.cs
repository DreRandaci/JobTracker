﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        [Display(Name = "Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }     

        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string JobLocation { get; set; }

        [Required]
        [Display(Name ="Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Link to Job Post")]
        public string JobUrl { get; set; }
        
        public ApplicationUser User { get; set; }

        public virtual ICollection<JobContact> JobContacts { get; set; }        
    }
}
