using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.Common
{
    public static class Extentions
    {
        public static int ExcuteScalar(this DbContext context, string storedStr, SqlParameter[] parameters = null)
        {
            string store = storedStr.ToExecString(parameters);
            return context.Database.ExecuteSqlRaw(store, parameters);
            //context.Database.ExecuteSqlRaw("EXEC [dbo].[Account_ActiveValue] @Email, @ActiveValue", parameters);
        }
        public static List<T> ExcuteToList<T>(this DbSet<T> dbSet, string storedStr, SqlParameter[] parameters = null) where T : class
        {
            if(parameters != null)
                return dbSet.FromSqlRaw(storedStr.ToExecuteString(parameters), parameters).ToList();
            else
                return dbSet.FromSqlRaw(storedStr.ToExecuteString(parameters)).ToList();
            //List<AccountProject> accs = context.AccountProjects.FromSqlRaw("EXECUTE Account_GetAllByProject").ToList();
            //List<AccountId> accs = context.AccountIds.FromSqlRaw("EXECUTE Account_GetIdByEmail {0}", email).ToList();
        }

        public static string ToExecuteString(this string storedStr, SqlParameter[] parameters = null)
        {
            string excuteStr = $"EXECUTE {storedStr}";
            return excuteStr.ParamsToString(parameters);
        }
        public static string ToExecString(this string storedStr, SqlParameter[] parameters = null)
        {
            string execStr = $"EXEC [dbo].[{storedStr}]";
            return execStr.ParamsToString(parameters);
        }
        public static string ParamsToString(this string str, SqlParameter[] parameters = null)
        {
            if (parameters != null)
                for (int i = 0, len = parameters.Length; i < len; i++)
                {
                    string paramName = parameters[i].ParameterName;
                    string pi = i == 0 ? $" @{paramName}" : $", @{paramName}";
                    str += pi;
                }

            return str;
        }
    }
}
