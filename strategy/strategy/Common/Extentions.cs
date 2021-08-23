using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace strategy.Common
{
    public static class Extentions
    {
        #region sql Extentions

        public static T GetValueOutput<T>(this SqlParameter[] paramArrs, string paramName)
        {
            var res = paramArrs.SingleOrDefault(t => t.ParameterName == paramName);
            if (res == null)
                throw new KeyNotFoundException("DAO Exception: Not found parameter name");
            T value = (T)res.Value;
            if (value != null)
                return value;

            throw new NullReferenceException("DAO Exception: Value null");
        }

        #endregion


        /// <summary>
        /// Description: Distinct list objects by one field
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <typeparam name="TKey">a field of object</typeparam>
        /// <param name="source"> some collection type</param>
        /// <param name="keySelector">lamda expression to distinct</param>
        /// <returns></returns>
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (T element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
        public static int ExecScalar<C>(this C context, string storedStr, SqlParameter[] parameters = null)
           where C : DbContext
        {
            string store = storedStr.ToExecString(parameters);
            return context.Database.ExecuteSqlRaw(store, parameters);
            //context.Database.ExecuteSqlRaw("EXEC [dbo].[Account_ActiveValue] @Email, @ActiveValue", parameters);
        }

        public static T ExecFirstOrDefault<T, C>(this C context, string storedStr, SqlParameter[] parameters = null)
            where C : DbContext
            where T : class
        {
            string store = storedStr.ToExecString(parameters);
            return context.Set<T>().FromSqlRaw(store, parameters).AsEnumerable().FirstOrDefault();
        }

        public static IEnumerable<T> ExecToList<T, C>(this C context, string storedStr, SqlParameter[] parameters = null)
            where C : DbContext
            where T : class
        {
            string store = storedStr.ToExecString(parameters);
            
            if (parameters != null)
                return context.Set<T>().FromSqlRaw(store, parameters).AsEnumerable();
            else
                return context.Set<T>().FromSqlRaw(store).AsEnumerable();
        }

        public static IEnumerable<T> ExcuteToList<T>(this DbSet<T> dbSet, string storedStr, SqlParameter[] parameters = null)
            where T : class
        {
            string store = storedStr.ToExecString(parameters);
            
            if (parameters != null)
                return dbSet.FromSqlRaw(store, parameters).AsEnumerable();

            else
                return dbSet.FromSqlRaw(store).AsEnumerable();

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
                    var direction = parameters[i].Direction;
                    string paramName = parameters[i].ParameterName;
                    if (direction == System.Data.ParameterDirection.Output)
                        paramName += " OUTPUT";

                    string pi = i == 0 ? $" {paramName}" : $", {paramName}";
                    str += pi;
                }

            return str;
        }
    }
}
