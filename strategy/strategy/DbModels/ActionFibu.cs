using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ActionFibu
    {
        public long Id { get; set; }
        public Guid ActionId { get; set; }
        public long FibuLandRegionId { get; set; }
        public long FibuKontenId { get; set; }
        public long KostenstellenId { get; set; }
        public decimal? FibuPercent { get; set; }
        public DateTime? FibuDate { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? ActionCostId { get; set; }
    }
}
