using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.Common
{
    public static class Extentions
    {       
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
