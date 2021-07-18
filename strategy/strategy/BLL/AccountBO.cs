using strategy.DAL;
using strategy.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace strategy.BLL
{    
    public class AccountBO
    {
        
        private List<Account> Accounts = new List<Account>();

        public List<AccountProject> GetAllByProject()
        {
            using AccountContext context = new();
            List<AccountProject> accs = context.AccountProjects.FromSqlRaw("EXECUTE Account_GetAllByProject").ToList();
            return accs;
        }
        
        public List<AccountId> GetInfoBy(string email)
        {
            if (string.IsNullOrEmpty(email)) return new List<AccountId>();
            using AccountContext context = new();
            List<AccountId> accs = context.AccountIds.FromSqlRaw("EXECUTE Account_GetIdByEmail {0}", email).ToList();
            return accs;
        }

        public AccountBO Get()
        {
            using (AccountContext context = new())
            {
                Accounts = context.Accounts.Where(a => a.DeletedBy == 0).ToList();
            }
            return this;
        }

        public List<Account> All()
        {
            return Accounts;
        }

        public List<Account> AllActive()
        {
            return Accounts.Where(a => a.IsActived).ToList();
        }

        public Account ById(long id)
        {
            return Accounts.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Update(Account item)
        {
            using AccountContext context = new();
            context.Update<Account>(item);
            context.SaveChanges();
        }
        public void Delete(Account item, long accountId)
        {
            // TODO: check Role

            item.DeletedBy = accountId;

            using AccountContext context = new();
            context.Update<Account>(item);
            context.SaveChanges();
        }
        public void Add(Account item)
        {
            using AccountContext context = new();
            context.Accounts.AddAsync(item);
            context.SaveChangesAsync();
        }

        public void AddRange(List<Account> items)
        {
            using AccountContext context = new();
            context.AddRange(items);
            context.SaveChanges();
        }
    }
}
