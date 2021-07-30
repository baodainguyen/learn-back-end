using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmAddressView
    {
        public long CrmAddressId { get; set; }
        public long? CatAddressId { get; set; }
        public long? CrmId { get; set; }
        public int? TypeId { get; set; }
        public string Street { get; set; }
        public string Nr { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public string AdditionAddress { get; set; }
        public string Department { get; set; }
        public long? CrmLandId { get; set; }
        public string CatAddressName { get; set; }
        public int? Mindex { get; set; }
        public int? CatAddressType { get; set; }
        public string CrmLandName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
