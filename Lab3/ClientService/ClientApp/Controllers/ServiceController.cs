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
    public class ServiceController : ControllerBase
    {
        private ServiceClient service = new ServiceClient();

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.ServiceFindAsync(id).Result);
        }

        [HttpPost]
        public IActionResult Post(Service service1)
        {
            return Ok(service.ServiceCreateAsync(service1));
        }

        [HttpPut]
        public IActionResult Put(Service service1)
        {
            return Ok(service.ServiceUpdateAsync(service1));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.ServiceDeleteAsync(id));
        }
    }
}
