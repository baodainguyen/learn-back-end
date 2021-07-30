using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class SubClient
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Mindex { get; set; }
        public long SubMarketId { get; set; }
        public string Description { get; set; }
        public int Mdf { get; set; }
        public long? OrganisationId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? GroupId { get; set; }
    }
}
