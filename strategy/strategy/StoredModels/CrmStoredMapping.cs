using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.StoredModels
{
    public class CrmAddressView
    {
        public long Id { get; set; }
        public long CatAddressId { get; set; }
        public long CrmId { get; set; }
        public string Street { get; set; }
        public string Nr { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public string CatAddressName { get; set; }
        public int CatAddressType { get; set; }
        public string CrmLandName { get; set; }
        public string AdditionAddress { get; set; }
        public long? CrmLandId { get; set; }
        public string Department { get; set; }
        public bool IsAddressControl { get; set; }

        public int MIndex { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class CrmObject
    {
        public long Id { get; set; }
        public Guid? GuId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Mdf { get; set; }
        public int MIndex { get; set; }

        public long ParentId { get; set; }
        public int ParentIndex { get; set; }
        public long ProjectId { get; set; }
    }

    public class CrmPersonExport
    {
        public long Id { get; set; }
        public long PerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string OrgName { get; set; }
        public string OrgAddress { get; set; }

        public long? SalutationId { get; set; }
        public string Salutation { get; set; }

        public long? TitleId { get; set; }
        public string Title { get; set; }

        public long? PositionId { get; set; }
        public string Position { get; set; }
        public bool IsActivePosition { get; set; }

        //
        public string PerNote { get; set; }
    }
    public class CrmObjectExport : CrmPersonExport
    {
        public long OrgId { get; set; }
        public int PerIndex { get; set; }
        public int OrgIndex { get; set; }
        public string PerMaskName { get; set; }

        //
        public string OrgNote { get; set; }
        public string OrgLegalForm { get; set; }
        public string OrgBranch { get; set; }
        public string OrgEmployee { get; set; }

        public DateTime OrgCreatedDate { get; set; }

        public CrmObjectExport()
        {
            OrgAdds = new List<CrmAddressView>();
            PerAdds = new List<CrmAddressView>();

            OrgPhones = new List<CrmObject>();
            OrgEmails = new List<CrmObject>();

            PerPhones = new List<CrmObject>();
            PerEmails = new List<CrmObject>();
        }

        public List<CrmAddressView> OrgAdds { get; set; }
        public List<CrmAddressView> PerAdds { get; set; }

        public List<CrmObject> OrgPhones { get; set; }
        public List<CrmObject> OrgEmails { get; set; }

        public List<CrmObject> PerPhones { get; set; }
        public List<CrmObject> PerEmails { get; set; }
        public long? CrmCrowdProjectId { get; set; }
        public string QuestionLink { get; set; }
    }
}
