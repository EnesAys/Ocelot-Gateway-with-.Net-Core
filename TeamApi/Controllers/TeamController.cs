using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TeamApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Beşiktaş", "Juventus" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Beşiktaş";
        }
    }
}
