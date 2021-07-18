using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmAnswerOption
    {
        public long CrmAnswerId { get; set; }
        public int SinglelineType { get; set; }
        public int? Digitlimitation { get; set; }
        public int? DecimalPlace { get; set; }
        public string Symbol { get; set; }
        public decimal? LessThan { get; set; }
        public decimal? GreaterThan { get; set; }

        public virtual CrmAnswer CrmAnswer { get; set; }
    }
}
