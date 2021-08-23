using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using strategy.StoredModels;
using System.Collections.Generic;

namespace strategy.DAL
{
    public class CrmContext : BaseContext
    {
        public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            base.OnModelCreating(modelBuilder);

        }

        
        public List<object> GetExportDataByPer(string pers, long projectId)
        {
            var sqlParams = new[]
            {
                new SqlParameter("@Pers", pers),
                new SqlParameter("@ProjectId", projectId)
            };

            var types = new[]
            {
                typeof(List<CrmObjectExport>),
                typeof(List<StoredModels.CrmAddressView>),
                typeof(List<CrmObject>),
                typeof(List<CrmObject>),
                typeof(List<StoredModels.CrmAddressView>),
                typeof(List<CrmObject>),
                typeof(List<CrmObject>)
            };

            return ExecuteToMultiObject(types, "CrmPerson_GetExportData", sqlParams);
        }

        public List<object> NewGetOrgExportData(string orgs, long projectId, bool isAll = false)
        {
            var sqlParams = new[]
            {
                new SqlParameter("@Orgs", orgs),
                new SqlParameter("@ProjectId", projectId),
                new SqlParameter("@IsAll", isAll)
            };

            var orgTypes = new[]
            {
                typeof(List<CrmOrganisationExport>),
                typeof(List<StoredModels.CrmAddressView>),
                typeof(List<StoredModels.CrmAddressView>),
                typeof(List<StoredModels.CrmInformationView>),
                typeof(List<StoredModels.CrmInformationView>),
                typeof(List<StoredModels.CrmTagView>),
                typeof(List<StoredModels.CrmOrganisationRelationship>),
                typeof(List<StoredModels.CrmPersonRelationship>),
                typeof(List<StoredModels.CrmPersonResponsibility>),
                typeof(List<StoredModels.CrmOrganisationResponsibility>)
            };

            return ExecuteToMultiObject(orgTypes, "CrmOrganisation_GetExportDataNew", sqlParams);
        }
    }
}
