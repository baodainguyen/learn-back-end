using strategy.DAL;
using strategy.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using strategy.Common;
using System;

namespace strategy.BLL
{    
    public class AccountBO : BaseBO
    {

        #region Stored Procedures
        public List<AccountProject> GetAllByProject()
        {
            using AccountContext context = new();
            List<AccountProject> accs = ExcuteToList(context.AccountProjects, "Account_GetAllByProject");

            return accs;
        }
        
        public List<AccountId> GetInfoBy(string email)
        {
            if (string.IsNullOrEmpty(email)) return new List<AccountId>();
            var parameters = new[] {
                new SqlParameter("Email", email)
            };
            using AccountContext context = new();
            List<AccountId> accs = ExcuteToList(context.AccountIds, "Account_GetIdByEmail", parameters);
            
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
            ExecScalar(context, "Account_ActiveValue", parameters);

            rowIndex = 0;
            return rowIndex;
        }
        public int UpdatePassword(AccountPass acc)
        {
            long id = acc.Id; 
            string pass = acc.Password;
            int rowIndex = -1;
            if (id < 1 || string.IsNullOrEmpty(pass))
                return rowIndex;

            var parameters = new[] {
                new SqlParameter("Id", id),
                new SqlParameter("Password", pass)
            };
            
            using AccountContext context = new();
            ExecScalar(context, "Account_ChangePassword", parameters);

            rowIndex = 0;
            return rowIndex;
        }

        #endregion

        #region EF Core
        public List<Account> GetAll()
        {
            using AccountContext context = new();
            return context.Accounts.ToList();
        }

        public List<Account> GetAllActive()
        {
            return GetAll().Where(a => a.IsActived).ToList();
        }

        public Account GetById(long id)
        {
            return GetAll().Where(a => a.Id == id).FirstOrDefault();
        }
        
        public int Update(Account item, long accountId = 0)
        {
            if(accountId > 0) item.ModifiedBy = accountId;
            item.ModifiedDate = DateTime.Now;
            using AccountContext c = new();
            {
                return Update(c, item);
            }
            
        }
        public int Delete(Account item, long accountId)
        {
            item.DeletedBy = accountId;
            item.DeletedDate = DateTime.Now;
            // TODO: check Role
            return Update(item);
            //using AccountContext c = new();
            //{
            //    c.Remove(item);
            //    return c.SaveChanges();
            //}
        }
        public int Add(Account item)
        {
            using AccountContext c = new();
            {
                c.Accounts.Add(item);
                return c.SaveChanges();
            }
            
        }

        public int AddRange(List<Account> items)
        {
            using AccountContext c = new();
            {
                c.Accounts.AddRange(items);
                //c.AddRange(items);
                return c.SaveChanges();
            }
        }
        #endregion
    }
}
