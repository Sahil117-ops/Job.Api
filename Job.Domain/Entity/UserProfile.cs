using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Domain.Entity
{
    public class UserProfile
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public required string Address1 { get; set; }
        public string? Address2 { get; set; }
        public int Age { get; set; }
        public int? CompanyId { get; set; } //Foreign key to Company...!!
        public Company? Company { get; set; } //Navigation property to Company...!!
    }
}
