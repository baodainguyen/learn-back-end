using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
