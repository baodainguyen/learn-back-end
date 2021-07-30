using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class Configuration
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public bool? Enable { get; set; }
        public bool? IsShow { get; set; }
        public int? Mindex { get; set; }
        public string Name { get; set; }
    }
}
