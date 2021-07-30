﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmPersonRelationship
    {
        public long Id { get; set; }
        public long CrmPersonId { get; set; }
        public long CrmId { get; set; }
        public int? TypeId { get; set; }
        public long? CategoryId { get; set; }
        public string Note { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual CrmPerson CrmPerson { get; set; }
    }
}