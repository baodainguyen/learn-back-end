using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ProjectGroup
    {
        public ProjectGroup()
        {
            Projects = new HashSet<Project>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int Mindex { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
