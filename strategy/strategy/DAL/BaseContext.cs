using System;
using System.Data;
using System.Linq;
using System.Data.Common;
using System.Reflection;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using strategy.DbModels;


namespace strategy.DAL
{
    public partial class BaseContext: DbContext
    {
        
        public BaseContext(DbContextOptions options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AccountLastAction>(entity =>
            {
                entity.ToTable("AccountLastAction");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Value).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        private MethodInfo _methodInfo;
        private MethodInfo GetDataMethod()
        {
            if (_methodInfo == null)
                _methodInfo = GetType().GetMethod("GetData", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
            return _methodInfo;
        }
        public static object GetData<T>(IDataReader dataReader, bool isGenericType)
        {
            var builder = DynamicBuilder<T>.CreateBuilder(dataReader);
            if (!isGenericType)
            {
                return dataReader.Read() ? builder.Build(dataReader) : default(T);
            }

            var res = new List<T>();
            while (dataReader.Read())
            {
                var record = builder.Build(dataReader);
                res.Add(record);
            }
            return res;
        }
        private List<object> ExecuteToMultiObject(IList<Type> types, DbCommand sqlCommand)
        {
            List<object> res;

            Database.OpenConnection();
            using (DbDataReader dataReader = sqlCommand.ExecuteReader())
            {
                if (dataReader.FieldCount == 0)
                {
                    return null;
                }

                res = new List<object>();
                var i = 0;
                var methodInfo = GetDataMethod();

                do
                {
                    var isGenericType = types[i].IsGenericType;
                    var reader = new object[] { dataReader, isGenericType };
                    var type = isGenericType ? types[i].GetGenericArguments()[0] : types[i];
                    var generic = methodInfo.MakeGenericMethod(type);

                    res.Add(generic.Invoke(this, reader));
                    i++;
                } while (i < types.Count && dataReader.NextResult());
            }
           // Database.CloseConnection();
            return res;
        }
        protected List<object> ExecuteToMultiObject(Type[] types, string queryString, params SqlParameter[] parameters)
        {
            FixParameterNullValue(parameters);
            List<object> res;
            using (DbCommand cmd = Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandText = queryString;//.ToExecString(parameters);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                res = ExecuteToMultiObject(types, cmd);
            }

            return res;
        }

        private static void FixParameterNullValue(ICollection<SqlParameter> sqlParameters)
        {
            if (sqlParameters.Count == 0)
                return;
            var query = sqlParameters.Where(par => par.Value == null);
            foreach (var par in query)
            {
                par.Value = DBNull.Value;
            }
        }
    }


}
