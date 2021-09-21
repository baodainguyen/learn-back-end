using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.Entity.MappingStore
{   
    public class CrmPersonSearchName
    {
        public long Id { get; set; }
        public string PersonName { get; set; }
        //public DateTime CreatedDate { get; set; } // ConnStr
        public string OrganisationName { get; set; }
        public string PositionName { get; set; }
        public string Note { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DueDate { get; set; }
        public string InfoValue { get; set; }
        public string TagName { get; set; }
        public string RelationshipNote { get; set; }
        public string Street { get; set; }
        public string Nr { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public string AdditionAddress { get; set; }
        public string Department { get; set; }
        public string CrmLandName { get; set; }
        public string Title { get; set; }
        public string SalutionName { get; set; }
        public string AccountName { get; set; }

    }
}
