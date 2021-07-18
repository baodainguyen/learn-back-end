using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmImportTemp
    {
        public int? Id { get; set; }
        public string NameOrganisation { get; set; }
        public long? Tag1Id { get; set; }
        public long? Anrede { get; set; }
        public long? Titel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Ort { get; set; }
        public string Plz { get; set; }
        public string SourceMail { get; set; }
        public string Website { get; set; }
        public long? Tag2Id { get; set; }
    }
}
