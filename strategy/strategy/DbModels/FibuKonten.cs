using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class FibuKonten
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string Nr { get; set; }
        public string Description { get; set; }
        public long? FibuLandRegionId { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
