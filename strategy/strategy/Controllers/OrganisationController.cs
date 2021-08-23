using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using strategy.BLL;
using strategy.DAL;
using strategy.StoredModels;
using System.Collections.Generic;

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
