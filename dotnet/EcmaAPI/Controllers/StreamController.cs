using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using EcmaAPI.Data;

namespace EcmaAPI.Controllers
{
    [ApiController]
    [Route("ecma/[controller]")]
    public class StreamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Stream> Get()
        {
            return DataTest.GetInstance().Streams.ToList();
        }

        // GET: ecma/stream/5
        [HttpGet("{id}")]
        public ActionResult<Stream> GetStream(long id)
        {
            var item = DataTest.GetInstance().FindStream(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }
    }
}
