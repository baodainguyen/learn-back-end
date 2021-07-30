using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmPerson
    {
        public CrmPerson()
        {
            CrmPersonRelationships = new HashSet<CrmPersonRelationship>();
            CrmPositions = new HashSet<CrmPosition>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Note { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int Mdf { get; set; }
        public long ProjectId { get; set; }
        public long? TitleId { get; set; }
        public long? SalutationId { get; set; }
        public long? TempId { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? TypeId { get; set; }
        public long? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<CrmPersonRelationship> CrmPersonRelationships { get; set; }
        public virtual ICollection<CrmPosition> CrmPositions { get; set; }
    }
}
