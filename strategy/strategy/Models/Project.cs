using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class Project
    {
        public Project()
        {
            CrmActivities = new HashSet<CrmActivity>();
            CrmCrowdProjectGroups = new HashSet<CrmCrowdProjectGroup>();
            CrmFilters = new HashSet<CrmFilter>();
            CrmFragensetGroups = new HashSet<CrmFragensetGroup>();
            CrmOrganisations = new HashSet<CrmOrganisation>();
            CrmPeople = new HashSet<CrmPerson>();
            Independencies = new HashSet<Independency>();
            Labels = new HashSet<Label>();
            Lands = new HashSet<Land>();
            MarketSegments = new HashSet<MarketSegment>();
            ProductGroups = new HashSet<ProductGroup>();
            ProjectLanguages = new HashSet<ProjectLanguage>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? ProjectGroupId { get; set; }
        public string PriorityGroupName { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public int? Mindex { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsApplyAllRegion { get; set; }
        public bool? IsOverDue { get; set; }
        public bool? IsShowMarketLabel { get; set; }
        public bool? IsHiddenGoalContent { get; set; }
        public bool? Isxy { get; set; }
        public bool? IsCheckActionDate { get; set; }

        public virtual ProjectGroup ProjectGroup { get; set; }
        public virtual ICollection<CrmActivity> CrmActivities { get; set; }
        public virtual ICollection<CrmCrowdProjectGroup> CrmCrowdProjectGroups { get; set; }
        public virtual ICollection<CrmFilter> CrmFilters { get; set; }
        public virtual ICollection<CrmFragensetGroup> CrmFragensetGroups { get; set; }
        public virtual ICollection<CrmOrganisation> CrmOrganisations { get; set; }
        public virtual ICollection<CrmPerson> CrmPeople { get; set; }
        public virtual ICollection<Independency> Independencies { get; set; }
        public virtual ICollection<Label> Labels { get; set; }
        public virtual ICollection<Land> Lands { get; set; }
        public virtual ICollection<MarketSegment> MarketSegments { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<ProjectLanguage> ProjectLanguages { get; set; }
    }
}
