using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class VideoLink
    {
        public long? TypeId { get; set; }
        public string Link { get; set; }
        public long Id { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
