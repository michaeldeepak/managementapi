using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using management.service;

namespace management.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ManagementService managementService;


        public ValuesController(ManagementService manageservice)
        {
            this.managementService = manageservice;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var manageData = managementService.Manage1();
            return manageData;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var secret = "Ty63rs4aVqcnh2vUqRJTbNT26caRZJ";
            var encrypted = "MzVWX4tH4yZWc/w75zUagUMEsP34ywSYISsIIS9fj0W3Q/lR0hBrHmdvMOt106PlKhN/1zXFBPbyKmI6nWC5BN54GuGFSjkxfuansJkfoi0=";
            return  managementService.OpenSSLDecrypt(encrypted, secret);



        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
