using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using strategy.BLL;
using strategy.DAL;
using strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : Controller //ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        readonly AccountBO mAccountBO = new AccountBO();

        public IActionResult Index()
        {
            return View();
        }



        #region Stored Procedures
        [HttpPut]
        public int ChangePass([FromBody] AccountPass acc)
        {
            return mAccountBO.UpdatePassword(acc);
        }

        [HttpGet]
        public IEnumerable<AccountProject> Get()
        {
            return mAccountBO.GetAllByProject();
        }

        [HttpGet("{id}")]
        public AccountProject Get(long id)
        {
            return mAccountBO.GetAllByProject().FirstOrDefault(e => e.Id == id);
        }
        
        // GET: account/getinfoby
        [HttpGet]
        public IEnumerable<AccountProject> GetInfoBy([FromBody] AccountActive account)
        {
            string email = account.Email;
            List<AccountId> accIds = mAccountBO.GetInfoBy(email);
            IEnumerable<AccountProject> accPrjs = mAccountBO.GetAllByProject();
            return accPrjs.Join(accIds,
                                prj => prj.Id,
                                acc => acc.Id,
                                (prj, acc) => prj);
        }

        // GET: account/activeby
        [HttpGet]
        public int ActiveBy([FromBody] AccountActive account)
        {
            string email = account.Email;
            string activeValue = account.ActiveValue;
            return mAccountBO.ActiveBy(email, activeValue);
        }

        #endregion

        #region EF Core
        [HttpPut]
        public int Update(Account item)
        {
            return mAccountBO.Update(item, 1);
        }

        [HttpGet("{id}")]
        public Account GetBy(long id)
        {
            return mAccountBO.GetById(id);
        }
        #endregion
    }
}
