﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ProductCompetition
    {
        public Guid Id { get; set; }
        public Guid SubMarketProductId { get; set; }
        public string Name { get; set; }
        public int MarketShare { get; set; }
        public string Color { get; set; }
        public int Mdf { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Colors { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? CriteriaId { get; set; }

        public virtual SubMarketProduct SubMarketProduct { get; set; }
    }
}