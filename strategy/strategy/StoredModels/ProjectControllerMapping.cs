using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.StoredModels
{
    public class ProjectGroupMemberRole
    {
        public int Role { get; set; }
        public List<ProjectGroupMember> Members { get; set; }
    }
}
