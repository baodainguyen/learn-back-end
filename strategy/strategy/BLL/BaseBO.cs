using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using strategy.Common;
using System.Collections.Generic;
using System.Linq;

namespace strategy.BLL
{
    public class BaseBO
    {

        public int Update<C, T>(C context, T item)
            where C : DbContext
            where T : class
        {
            context.Update(item);
            return context.SaveChanges();

        }

        public int ExecScalar<C>(C context, string storedStr, SqlParameter[] parameters = null)
            where C : DbContext
        {
            string store = storedStr.ToExecString(parameters);
            return context.Database.ExecuteSqlRaw(store, parameters);
            //context.Database.ExecuteSqlRaw("EXEC [dbo].[Account_ActiveValue] @Email, @ActiveValue", parameters);
        }
        public List<T> ExcuteToList<T>(DbSet<T> dbSet, string storedStr, SqlParameter[] parameters = null) 
            where T : class
        {
            string store = storedStr.ToExecuteString(parameters);
            IEnumerable<T> datasOut;
            if (parameters != null)
                datasOut = dbSet.FromSqlRaw(store, parameters).AsEnumerable<T>();
            else
                datasOut = dbSet.FromSqlRaw(store).AsEnumerable<T>();

            return datasOut.ToList();
            //List<AccountProject> accs = context.AccountProjects.FromSqlRaw("EXECUTE Account_GetAllByProject").ToList();
            //List<AccountId> accs = context.AccountIds.FromSqlRaw("EXECUTE Account_GetIdByEmail {0}", email).ToList();
        }
    }
}
