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
    [Route("[controller]")]
    public class AccountController : Controller //ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        readonly AccountBO mAccBO = new AccountBO();

        //[HttpGet]
        //public IActionResult GetItems()
        //{
        //    var items = mAccBO.GetAllByProject();
        //    return Ok(items);
        //}

        //[HttpGet]
        //public IEnumerable<AccountProject> Get()
        //{
        //    return mAccBO.GetAllByProject();
        //}
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<AccountProject> Get()
        {
            return mAccBO.GetAllByProject();
        }

    }
}
