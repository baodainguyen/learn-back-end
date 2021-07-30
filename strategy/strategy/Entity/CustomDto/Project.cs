using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.Entity.CustomDto
{
    public class ProjectByMember
    {
        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string Member { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? IsRole { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public int Mdf { get; set; }
        public int MIndex { get; set; }
        public bool ShowButton { get; set; }
        public bool IsEdit { get; set; }
        public bool IsDelete { get; set; }
        public bool IsCopy { get; set; }
        public bool IsActive { get; set; }
        public long StrategyId { get; set; } //issues 4859
        public string Url { get; set; }

    }
    
}
