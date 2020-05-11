using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference;

namespace Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        ServiceClient service = new ServiceClient();

        [HttpGet]
        public string Get()
        {
            var response = service.GetDataAsync().Result;
            return JsonSerializer.Deserialize<Dictionary<string, string>>(response).First().Value.Replace(' ', '_');
        }

    }
}