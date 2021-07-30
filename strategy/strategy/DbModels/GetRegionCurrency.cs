using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class GetRegionCurrency
    {
        public long Id { get; set; }
        public string CurrencyName { get; set; }
    }
}
