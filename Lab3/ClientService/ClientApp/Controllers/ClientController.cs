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
    public class ClientController : ControllerBase
    {
        private ServiceClient service = new ServiceClient();

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.ClientFindAsync(id).Result);
        }

        [HttpPost]
        public IActionResult Post(Client client)
        {
            return Ok(service.ClientCreateAsync(client));
        }

        [HttpPut]
        public IActionResult Put(Client client)
        {
            return Ok(service.ClientUpdateAsync(client));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.ClientDeleteAsync(id));
        }
    }
}
