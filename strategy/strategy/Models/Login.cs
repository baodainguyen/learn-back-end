using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Language { get; set; }
        public bool? IsActive { get; set; }
        public int? Mindex { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? DeletedBy { get; set; }
    }
}
