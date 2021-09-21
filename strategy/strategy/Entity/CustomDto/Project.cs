using System;
using System.Collections.Generic;
using strategy.Common;
using System.Threading.Tasks;

namespace strategy.Entity.CustomDto
{
    public class CrmFilterItem
    {
        public int Operator { get; set; }
        public int PropertyId { get; set; }
        public int Keyword { get; set; }
        public object Value { get; set; }
        public object ValueSecond { get; set; }
        public string ValueThird { get; set; } = string.Empty;
        public int MIndex { get; set; }
        public SettingType TypeCrowdFilter { get; set; }
    }
    public class CrmFilterData
    {
        public int TypeId { get; set; }
        public List<CrmFilterItem> CrmFilterItems { get; set; }
        public long IdFocus { get; set; }
        public long IdFilter { get; set; }
        public DateTime CreatedDate { get; set; }
    }
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
