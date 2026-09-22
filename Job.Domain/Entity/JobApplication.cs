using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Domain.Entity
{
    public class JobApplication
    {
        public int Id { get; set; }
        public int UserProfileId { get; set; } //Foreign key to User...!!
        public int JobPostId { get; set; } //Foreign key to Job...!!
        public required string Education { get; set; }
        public string? Address { get; set; }
        public required string AppliedOn { get; set; }
    }
}
