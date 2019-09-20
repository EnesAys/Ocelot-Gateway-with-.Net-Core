using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SportApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Soccer", "Basketball" };
        }
    }
}
