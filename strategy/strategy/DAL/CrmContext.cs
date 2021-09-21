using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using strategy.StoredModels;
using System.Collections.Generic;
using System.Linq;
using System;
using strategy.Common;
using strategy.Entity.MappingStore;

namespace strategy.DAL
{
    public class CrmContext : BaseContext
    {
        public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.Entity<CrmPersonSearchName>(entity =>
            {
                entity.Property(e => e.Id);
                entity.Property(e => e.PersonName);
                //entity.Property(e => e.CreatedDate);  // ConnStr
                entity.Property(e => e.OrganisationName);
                entity.Property(e => e.PositionName);
                entity.Property(e => e.Note);
                entity.Property(e => e.FirstName);
                entity.Property(e => e.LastName);
                entity.Property(e => e.DueDate);
                entity.Property(e => e.InfoValue);
                entity.Property(e => e.TagName);
                entity.Property(e => e.RelationshipNote);
                entity.Property(e => e.Street);
                entity.Property(e => e.Nr);
                entity.Property(e => e.Plz);
                entity.Property(e => e.Ort);
                entity.Property(e => e.AdditionAddress);
                entity.Property(e => e.Department);
                entity.Property(e => e.CrmLandName);
                entity.Property(e => e.Title);
                entity.Property(e => e.SalutionName);
                entity.Property(e => e.AccountName);

                entity.HasNoKey();
            });

            base.OnModelCreating(modelBuilder);

        }

        public List<CrmPersonSearchName> GetPersons(params SqlParameter[] sqlParams){            
            return this.ExecToList<CrmPersonSearchName, CrmContext>("CrmPerson_SearchAll", sqlParams).ToList();
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
