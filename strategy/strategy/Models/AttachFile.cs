using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class AttachFile
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhysicalName { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public long? ProjectId { get; set; }
        public string ObjectId { get; set; }
        public int ObjectType { get; set; }
        public int Mindex { get; set; }
        public int? Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? Size { get; set; }
    }
}
