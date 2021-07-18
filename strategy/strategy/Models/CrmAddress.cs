using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmAddress
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public long? CrmId { get; set; }
        public int? TypeId { get; set; }
        public string Street { get; set; }
        public string Nr { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public long? CrmLandId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string AdditionAddress { get; set; }
        public string Department { get; set; }
    }
}
