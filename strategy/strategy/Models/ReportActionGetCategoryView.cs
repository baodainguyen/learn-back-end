using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ReportActionGetCategoryView
    {
        public Guid ActionId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
    }
}
