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
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [Required]
        public int ApiId { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public string JobLocation { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string HowToApply { get; set; }

        [Required]
        public string JobUrl { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool Applied { get; set; }

        public virtual ICollection<JobContact> JobContacts { get; set; }

        public Job()
        {
            this.Applied = false;
        }
    }
}
