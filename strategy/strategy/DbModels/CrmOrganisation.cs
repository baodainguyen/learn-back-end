using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmOrganisation
    {
        public CrmOrganisation()
        {
            CrmPositions = new HashSet<CrmPosition>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public long? LegalForm { get; set; }
        public long? Branch { get; set; }
        public long? Employee { get; set; }
        public string Note { get; set; }
        public long ProjectId { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string KundenNr { get; set; }
        public long? Revenue { get; set; }
        public long? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<CrmPosition> CrmPositions { get; set; }
    }
}
