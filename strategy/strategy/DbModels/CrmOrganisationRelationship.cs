using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmOrganisationRelationship
    {
        public long Id { get; set; }
        public long CrmOrganisationId { get; set; }
        public long CrmId { get; set; }
        public long CategoryId { get; set; }
        public string Note { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? Mindex { get; set; }
    }
}
