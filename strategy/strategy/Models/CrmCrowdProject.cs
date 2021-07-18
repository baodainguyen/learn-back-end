using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmCrowdProject
    {
        public CrmCrowdProject()
        {
            CrmFiltersCrowds = new HashSet<CrmFiltersCrowd>();
            CrmTagMappings = new HashSet<CrmTagMapping>();
        }

        public long Id { get; set; }
        public long CrmCrowdProjectGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? CrmFragensetId { get; set; }
        public string Logo { get; set; }
        public string Subject { get; set; }
        public string EmailContent { get; set; }
        public int Mdf { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDescription { get; set; }
        public bool? IsOrderLabel { get; set; }
        public double? CampaignDay { get; set; }
        public TimeSpan? CampaignTime { get; set; }
        public string CampaignDescription { get; set; }
        public string CurrentLang { get; set; }
        public bool IsPagging { get; set; }
        public int? ReportId { get; set; }
        public bool IsNotNavigator { get; set; }
        public long? CrmAccountSmtpId { get; set; }
        public bool IsAllowPdfPerson { get; set; }
        public bool IsAllowPdfActivities { get; set; }
        public int? TypeId { get; set; }
        public string MonitorDescription { get; set; }
        public bool? IsAutoSend { get; set; }
        public string FinishText { get; set; }
        public long? WordTemplateId { get; set; }

        public virtual CrmCrowdProjectGroup CrmCrowdProjectGroup { get; set; }
        public virtual ICollection<CrmFiltersCrowd> CrmFiltersCrowds { get; set; }
        public virtual ICollection<CrmTagMapping> CrmTagMappings { get; set; }
    }
}
