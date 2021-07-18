using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ImageBrowser
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? Size { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long ProjectId { get; set; }
        public string Type { get; set; }
    }
}
