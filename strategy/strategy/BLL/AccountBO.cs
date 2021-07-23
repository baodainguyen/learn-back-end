using strategy.DAL;
using strategy.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using strategy.Common;

namespace strategy.BLL
{    
    public class AccountBO : BaseBO<AccountContext, Account>
    {  
        public List<AccountProject> GetAllByProject()
        {
            using AccountContext context = new();
            List<AccountProject> accs = context.AccountProjects.ExcuteToList("Account_GetAllByProject");
            return accs;
        }
        
        public List<AccountId> GetInfoBy(string email)
        {
            if (string.IsNullOrEmpty(email)) return new List<AccountId>();
            var parameters = new[] {
                new SqlParameter("Email", email)
            };
            using AccountContext context = new();
            List<AccountId> accs = context.AccountIds.ExcuteToList("Account_GetIdByEmail", parameters);
            return accs;
        }
        
        public int ActiveBy(string email, string activeValue)
        {
            int rowIndex = -1;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(activeValue))
                return rowIndex;

            var parameters = new[] {
                new SqlParameter("Email", email),
                new SqlParameter("ActiveValue", activeValue)
            };
            
            using AccountContext context = new();
            context.ExcuteScalar("Account_ActiveValue", parameters);

            rowIndex = 0;
            return rowIndex;
        }


        public List<Account> GetAllActive()
        {
            return GetAll().Where(a => a.IsActived).ToList();
        }

        public Account GetById(long id)
        {
            return GetAll().Where(a => a.Id == id).FirstOrDefault();
        }

    }
}
