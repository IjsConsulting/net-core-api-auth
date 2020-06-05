using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using net_core_api_auth.Models;

namespace net_core_api_auth.Controllers
{
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet("people/all")]
        [Authorize]
        public ActionResult<IEnumerable<Person>> GetAll()
        {
            return new[]
            {
                new Person { Name = "Ana" },
                new Person { Name = "Felipe" },
                new Person { Name = "Emillia" }
            };
        }
    }
}