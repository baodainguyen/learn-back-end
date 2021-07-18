using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmAccountSmtp
    {
        public long Id { get; set; }
        public long ProjectId { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Smtpserver { get; set; }
        public string Port { get; set; }
        public bool? Ssl { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
