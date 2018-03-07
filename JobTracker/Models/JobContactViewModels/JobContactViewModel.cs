using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models.JobContactViewModels
{
    public class JobContactViewModel
    {
        public ICollection<Job> Jobs { get; set; }
    }
}
