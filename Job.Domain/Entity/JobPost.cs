using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Domain.Entity
{
    public class JobPost
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateOnly CreatedOn { get; set; }
        public DateOnly? ValidTill { get; set; }
        public DateOnly? ModifiedOn { get; set; }
    }
}
