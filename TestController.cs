using ApiKeyAuth.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ApiKeyAuth
{
    public class TestController: ControllerBase
    {
        [ApiKey]
        [HttpGet("authorized")]
        public IActionResult Get()
        {
            return Ok("authorized endpoint with api-key");
        }

        [HttpGet("not-authorized")]
        public IActionResult NotAuthorized()
        {
            return Ok("not authorized enpoint");
        }
    }
}
