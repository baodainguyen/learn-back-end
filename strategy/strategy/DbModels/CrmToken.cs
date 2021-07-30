using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmToken
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string DeviceId { get; set; }
        public string Platform { get; set; }
        public string LoginToken { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? DeletedBy { get; set; }
    }
}
