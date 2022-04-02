using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APi_CICD.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController2 : ControllerBase
    { [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}