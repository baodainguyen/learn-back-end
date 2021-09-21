using System;
using strategy.DAL;
using strategy.StoredModels;
using System.Collections.Generic;
using strategy.Entity.CustomDto;
using strategy.Entity.MappingStore;
using System.Linq;
using strategy.Entity;
using Microsoft.Data.SqlClient;

namespace strategy.BLL
{
    public class OrganisationBO
    {
        private readonly CrmContext context;
        public OrganisationBO(CrmContext context)
        {
            this.context = context;
        }

        public List<CrmPersonSearchName> GetSearchName(CrmPersonEntry entry, string name = null)
        {
            if (string.IsNullOrEmpty(name)) name = string.Empty;

            List<CrmPersonSearchName> personlist = context.GetPersons(
                new SqlParameter("@ProjectId", entry.ProjectId), new SqlParameter("@AccountId", entry.AccountId));

            personlist = personlist.Where(x =>
               (x.FirstName != null && x.LastName != null &&
               (string.Format("{0} {1}", x.FirstName, x.LastName).Contains(name, StringComparison.OrdinalIgnoreCase))) ||
               (x.FirstName != null && x.LastName != null &&
                (string.Format("{0} {1}", x.LastName, x.FirstName).Contains(name, StringComparison.OrdinalIgnoreCase))) ||
               (x.Street != null && x.Street.Contains(name, StringComparison.OrdinalIgnoreCase)) || 
               (x.Nr != null && x.Nr.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.Plz != null && x.Plz.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.Ort != null && x.Ort.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.AdditionAddress != null && x.AdditionAddress.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.Department != null && x.Department.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.CrmLandName != null && x.CrmLandName.Contains(name, StringComparison.OrdinalIgnoreCase)) || 
               (x.Note != null && x.Note.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.InfoValue != null && x.InfoValue.Contains(name, StringComparison.OrdinalIgnoreCase)) || 
               (x.TagName != null && x.TagName.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.PositionName != null && x.PositionName.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.Title != null && x.Title.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.SalutionName != null && x.SalutionName.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.AccountName != null && x.AccountName.Contains(name, StringComparison.OrdinalIgnoreCase))
               || (x.RelationshipNote != null && x.RelationshipNote.Contains(name, StringComparison.OrdinalIgnoreCase)))
                   .ToList();

            return personlist;
        }
        
        public List<object> GetExportDataOrg(DataOrg org)
        {
            string ids = org.Ids;
            long projectId = org.ProjectId;

            return context.NewGetOrgExportData(ids, projectId, true);
        }
    }
}
