using strategy.DAL;
using strategy.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using strategy.Common;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using strategy.StoredModels;

namespace strategy.BLL
{
    public class AccountBO
    {
        private readonly AccountContext context;

        public AccountBO(AccountContext context)
        {
            this.context = context;
        }
        public AccountInfo GetUserForEdit(long accountId, long projectGroupId, long projectId, out bool canDeleted, out bool isUsed)
        {
            bool HasRoleForDelete = true;// hardoce
                        
            var sqlParams = new[]
            {
                new SqlParameter("@Id", accountId),
                new SqlParameter("@ProjectGroupId", projectGroupId),
                new SqlParameter("@ProjectId", projectId),
                new SqlParameter("@IsUsed", SqlDbType.Bit){ Direction = ParameterDirection.Output }
            };
            AccountInfo account = context.ExecFirstOrDefault<AccountInfo, AccountContext>("Account_GetInfoForEdit", sqlParams);
            isUsed = sqlParams.GetValueOutput<bool>("@IsUsed");
            canDeleted = !isUsed && HasRoleForDelete;

            if (account == null) return new AccountInfo();
            return account;
        }
    }
}
