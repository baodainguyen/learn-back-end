using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmActivityCategoryViewForFilter
    {
        public long CrmId { get; set; }
        public string CatName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
