using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class TempFragenset
    {
        public Guid Id { get; set; }
        public long IdOld { get; set; }
        public long IdNew { get; set; }
        public string Type { get; set; }
    }
}
