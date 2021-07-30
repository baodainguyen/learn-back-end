using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmOrganisationWithDueDateView
    {
        public long Id { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
