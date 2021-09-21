using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using strategy.BLL;
using strategy.DAL;
using strategy.StoredModels;
using System.Collections.Generic;
using strategy.Entity;
using strategy.Entity.MappingStore;

namespace strategy.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrganisationController : Controller
    {
        private readonly ILogger<OrganisationController> _logger;
        private readonly OrganisationBO organisation;

        public OrganisationController(ILogger<OrganisationController> logger, CrmContext context)
        {
            _logger = logger;
            organisation = new OrganisationBO(context);
        }

        // GET: organisation/getCrmPeople/lang=en&projid=440855    // entry.AccountId = 80156; ConnStr
        // GET: organisation/getCrmPeople/lang=en&projid=62689     // entry.AccountId = 20217; ConnPC037
        [HttpGet("lang={lang}&projid={projid}")]
        public List<CrmPersonSearchName> GetCrmPeople(string lang, long projid)
        {
            CrmPersonEntry entry = new(lang, projid);   // en, 440855
            //entry.AccountId = 80156;        // ConnStr
            entry.AccountId = 20217;        // ConnPC037
            return organisation.GetSearchName(entry);
        }
        [HttpPost]       // POST: organisation/getexport
        public IEnumerable<object> GetExport(DataOrg orgs)
        {
            if (string.IsNullOrEmpty(orgs.Ids) || orgs.ProjectId < 1)
            {
                return new List<object>();
            }
            return organisation.GetExportDataOrg(orgs);
        }
    }
}
