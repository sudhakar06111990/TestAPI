using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hello1Controller : Controller
    {
        [HttpGet]
       public IActionResult Get()
        {
            return Ok("hello world");
        }

        [HttpPost]
        public IActionResult Post(JObject payload)
        {
            return Ok(payload);
        }
    }
}
