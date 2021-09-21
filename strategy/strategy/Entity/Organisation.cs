using System;
using System.Collections.Generic;
using strategy.Entity.CustomDto;
using strategy.Entity.MappingStore;

namespace strategy.Entity
{
    public class CrmPersonEntry
    {
        public CrmPersonEntry(string lang, long projid)
        {
            Lang = lang;
            ProjectId = projid;
        }
        public long ProjectId { get; set; }
        public long AccountId { get; set; }
        public string Lang { get; set; }
    }
        
}
