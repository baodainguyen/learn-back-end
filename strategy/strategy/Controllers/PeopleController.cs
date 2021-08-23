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
    public class PeopleController : Controller
    {
        private readonly ILogger<PeopleController> _logger;
        private readonly PeopleBO people;

        public PeopleController(ILogger<PeopleController> logger, CrmContext context)
        {
            _logger = logger;
            people = new PeopleBO(context);
        }

        [HttpPost]       // POST: people/getexport
        public IEnumerable<object> GetExport(DataPeople peopleId)
        {
            if (string.IsNullOrEmpty(peopleId.PersonIds) || peopleId.ProjectId < 1)
            {
                return new List<object>();
            }
            return people.GetExportDataByPer(peopleId);
        }
    }
}
