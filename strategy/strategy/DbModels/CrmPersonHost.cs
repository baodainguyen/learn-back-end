using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmPersonHost
    {
        public long Id { get; set; }
        public long CrmPersonId { get; set; }
        public string IpAddress { get; set; }
        public string HostName { get; set; }
        public string RemotePort { get; set; }
        public string Protocol { get; set; }
        public string EmuleId { get; set; }
        public string Proxy { get; set; }
        public string Land { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long? StatusId { get; set; }
        public long? CrmActivityId { get; set; }
    }
}
