using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using strategy.BLL;
using strategy.DAL;
using strategy.DbModels;
using strategy.StoredModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategy.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProjectGroupController : Controller
    {
        private readonly ILogger<ProjectGroupController> _logger;
        private readonly ProjectGroupBO projectGroup;

        public ProjectGroupController(ILogger<ProjectGroupController> logger, ProjectGroupContext context)
        {
            _logger = logger;
            projectGroup = new ProjectGroupBO(context);
        }

        [HttpGet("{accid}/{projectgroupid}")]       // GET: projectgroup/getmemberprojectgroup/3/80042
        public ProjectGroupMemberRole GetMemberProjectGroup(long accid, long projectgroupid)
        {
            return projectGroup.GetMemberByProjectGroupId(projectgroupid, accid);
        }

        [HttpGet("{accountid}")]       // GET: projectgroup/get
        public IEnumerable<ProjectGroupObj> Get(long accountid)
        {
            return projectGroup.Get(accountid);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
