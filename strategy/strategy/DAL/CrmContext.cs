using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using strategy.DbModels;
using strategy.StoredModels;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace strategy.DAL
{
    public class CrmContext : BaseContext
    {
        public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            

            base.OnModelCreating(modelBuilder);

        }

        private MethodInfo _methodInfo;
        private MethodInfo GetDataMethod()
        {
            if (_methodInfo == null)
                _methodInfo = GetType().GetMethod("GetData", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            return _methodInfo;
        }
        public List<object> ExecuteToMultiObject(string pers, long projectId)
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
    }
}
