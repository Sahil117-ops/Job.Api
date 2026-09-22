using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Domain.Entity
{
    public class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; } //Foreign key to User...!!
        public int RoleId { get; set; } //Foreign key to Role...!!
    }
}
