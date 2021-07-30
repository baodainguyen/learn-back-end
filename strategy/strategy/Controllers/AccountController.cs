using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using strategy.BLL;
using strategy.Common;
using strategy.DAL;
using strategy.DbModels;
using strategy.Models;
using strategy.StoredModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace strategy.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : Controller //ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly AccountBO account;

        public AccountController(ILogger<AccountController> logger, AccountContext context)
        {
            _logger = logger;
            account = new AccountBO(context);
        }


        public IActionResult Index()
        {
            return View();
        }

        #region Stored Procedures
        [HttpGet("{accountid}/{projectgroupid}/{projectid}")]       // GET: account/getuserforedit
        public object GetUserForEdit(long accountid, long projectgroupid, long projectid)
        {
            bool canDeleted, isUsed;
            AccountInfo accInfo = account.GetUserForEdit(accountid, projectgroupid, projectid,out canDeleted,out isUsed);

            return new { 
                Info = accInfo, 
                CanDeleted = canDeleted, 
                IsUsed = isUsed 
            };
        }

        //[HttpPut]       // PUT: account/changepass
        //public int ChangePass([FromBody] AccountPass acc)
        //{
        //    long id = acc.Id;
        //    string pass = acc.Password;
        //    int rowIndex = -1;
        //    if (id < 1 || string.IsNullOrEmpty(pass))
        //        return rowIndex;

        //    var parameters = new[] {
        //            new SqlParameter("@Id", id),
        //            new SqlParameter("@Password", pass)
        //        };

        //    aContext.ExecScalar("Account_ChangePassword", parameters);

        //    rowIndex = 0;
        //    return rowIndex;
        //}

        //[HttpGet]       // GET: account/getinfoby
        //public IEnumerable<AccountProject> GetInfoBy([FromBody] AccountActive account)
        //{
        //    string email = account.Email;
        //    IEnumerable<AccountProject> datas = new List<AccountProject>();
        //    if (string.IsNullOrEmpty(email)) return datas;
        //    IEnumerable<AccountId> accIds = new List<AccountId>();
        //    var parameters = new[] {
        //        new SqlParameter("@Email", email)
        //    };
        //    accIds = aContext.AccountIds.ExecToList("Account_GetIdByEmail", parameters);

        //    IEnumerable<AccountProject> accPrjs = Get();
        //    return accPrjs.Join(accIds,
        //                        prj => prj.Id,
        //                        acc => acc.Id,
        //                        (prj, acc) => prj);
        //}

        #endregion

        #region EF Core
        //[HttpPost]      // GET: account/create
        //public int Create(Account item)
        //{
        //    aContext.Add(item);
        //    return aContext.SaveChanges();
        //}
        //[HttpPut]      // PUT: account/update
        //public int Update(Account item)
        //{
        //    item.ModifiedBy = 1;
        //    item.ModifiedDate = DateTime.Now;
        //    aContext.Update(item);
        //    return aContext.SaveChanges();
        //}

        //[HttpGet("{id}")]      // GET: account/getby
        //public Account GetBy(long id)
        //{
        //    Account acc = aContext.Accounts.Where(a => a.Id == id).FirstOrDefault();
        //    if (acc == null)
        //        return new Account();

        //    return acc;
        //}
        #endregion
    }
}
