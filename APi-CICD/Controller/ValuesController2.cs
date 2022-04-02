using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APi_CICD.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController2 : ControllerBase
    { [HttpGet]
        public ActionResult<IEnumerable<int>> Get()
        {
            //return random number
            return new int[] { 1, 2, 3, 4, 5 };
        }
        [HttpGet("a")]
        public ActionResult<IEnumerable<int>> Get2()
        {
            //return random number
            return new int[] { 1, 2, 3, 4, 5 };
        }
    }
}