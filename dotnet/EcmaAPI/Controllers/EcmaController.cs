using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcmaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EcmaController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EcmaController> _logger;

        public EcmaController(ILogger<EcmaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<EntityModel> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new EntityModel
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToList();
        }

        
    }
}
