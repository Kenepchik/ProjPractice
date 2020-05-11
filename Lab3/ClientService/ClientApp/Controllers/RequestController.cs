using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllServiceReference;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private ServiceClient service = new ServiceClient();

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.RequestFindAsync(id).Result);
        }

        [HttpPost]
        public IActionResult Post(Request request)
        {
            return Ok(service.RequestCreateAsync(request));
        }

        [HttpPut]
        public IActionResult Put(Request request)
        {
            return Ok(service.RequestUpdateAsync(request));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.RequestDeleteAsync(id));
        }
    }
}
