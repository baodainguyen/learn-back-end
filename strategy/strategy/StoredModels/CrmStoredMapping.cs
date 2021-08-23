using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace strategy.StoredModels
{
    public class CrmOrganisationResponsibility
    {
        public long Id { get; set; }
        public long CrmOrganisationId { get; set; }
        public long AccountId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public string AccountName { get; set; }
    }
    public class CrmPersonResponsibility
    {
        public long Id { get; set; }//
        public long CrmPersonId { get; set; }//
        public long AccountId { get; set; }//
        public long? CreatedBy { get; set; }//
        public DateTime CreatedDate { get; set; }
        public long DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public string AccountName { get; set; }
    }
    public class CrmPersonRelationship
    {
        public long Id { get; set; }//
        public long CrmPersonId { get; set; }//
        public long CrmId { get; set; }//
        public int? TypeId { get; set; }//
        public long? CategoryId { get; set; }//
        public string CategoryName { get; set; }
        public string Note { get; set; }//
        public long? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }//
        public long? ModifiedBy { get; set; }//
        public DateTime? ModifiedDate { get; set; }//
        public long? DeletedBy { get; set; }//
        public DateTime? DeletedDate { get; set; }//
    }
    public class CrmOrganisationRelationship
    {
        public long Id { get; set; }//
        public long CrmOrganisationId { get; set; }//
        public long CrmId { get; set; }//
        public long? FirstCrmId { get; set; }
        public string CrmName { get; set; }
        public long? CategoryId { get; set; }//
        public string CategoryName { get; set; }
        public string Note { get; set; }//
        public int MIndex { get; set; }//
        public long? CreatedBy { get; set; }//
        public DateTime CreatedDate { get; set; }//
        public long? ModifiedBy { get; set; }//
        public DateTime? ModifiedDate { get; set; }//
        public long? DeletedBy { get; set; }//
        public DateTime? DeletedDate { get; set; }//
        public int DataState { get; set; } = (int)DataRowState.Unchanged;
        public bool IsVisible { get; set; } = true;
        public int TypeId { get; set; }
    }

    [Serializable]
    public class CrmTagView
    {
        public long CategoryId { get; set; }//
        public long CrmId { get; set; }//
        public string Name { get; set; } = "";
        public int TypeId { get; set; }//
    }
    public class CrmInformationView
    {
        public long Id { get; set; }//
        public long CatInformationId { get; set; }
        public long CrmId { get; set; }//
        public string Value { get; set; }//
        public string CatInformationName { get; set; }
        public int CatInfoType { get; set; }
        public string Extension { get; set; }
    }
    public class CrmOrganisationExport : CrmPersonExport
    {
        public long OrgFakeId { get; set; }
        public long PerFakeId { get; set; }
        public long OrgId { get; set; }
        public int PerIndex { get; set; }
        public int OrgIndex { get; set; }
        public string PerMaskName { get; set; }
        public string OrgNote { get; set; }
        public long? OrgLegalFormId { get; set; }
        public string OrgLegalForm { get; set; }
        public long? OrgBranchId { get; set; }
        public string OrgBranch { get; set; }
        public long? OrgEmployeeId { get; set; }
        public string OrgEmployee { get; set; }
        public long? OrgRevenueId { get; set; }
        public string OrgRevenue { get; set; }
        public DateTime OrgCreatedDate { get; set; }
        public List<CrmAddressView> OrgAdds { get; set; } = new List<CrmAddressView>();
        public List<CrmAddressView> PerAdds { get; set; } = new List<CrmAddressView>();
        public List<CrmInformationView> OrgInfos { get; set; } = new List<CrmInformationView>();
        public List<CrmInformationView> PerInfos { get; set; } = new List<CrmInformationView>();
        public List<CrmTagView> OrgTags { get; set; } = new List<CrmTagView>();
        public List<CrmTagView> PerTags { get; set; } = new List<CrmTagView>();
        public bool IsNew { get; set; } = true;
        public List<CrmPositionExport> Positions { get; set; } = new List<CrmPositionExport>();
        public long? DesOrgId { get; set; }
        public long? DesPerId { get; set; }
        public string OrgRelationshipJson { get; set; }
        public string PerRelationshipJson { get; set; }
        public string PerRes { get; set; }
        public string OrgRes { get; set; }
        public int DesOrgMdf { get; set; }
        public int DesPerMdf { get; set; }
        public string KundenNr { get; set; }
        public void DistinctData()
        {

        }
    }
    public class CrmPositionExport
    {
        public long OrgFakeId { get; set; }
        public long PosisionId { get; set; }
        public string Position { get; set; }
        public long OrgId { get; set; }
        public bool IsActive { get; set; } = true;
    }
    public class CrmAddressView
    {
        public long Id { get; set; }
        public long CatAddressId { get; set; }//
        public long CrmId { get; set; }//
        public string Street { get; set; }//
        public string Nr { get; set; }//
        public string Plz { get; set; }//
        public string Ort { get; set; }//
        public string CatAddressName { get; set; }//
        public int CatAddressType { get; set; }//
        public string CrmLandName { get; set; }
        public long? CrmLandId { get; set; }//
        public string AdditionAddress { get; set; }//
        public string Department { get; set; }
        public bool IsAddressControl { get; set; }
        public int MIndex { get; set; }//
        public DateTime CreatedDate { get; set; }//
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
