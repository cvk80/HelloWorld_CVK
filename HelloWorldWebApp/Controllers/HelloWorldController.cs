using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldWebApp.Controllers
{
    public class HelloWorldController : ApiController
    {
        // GET api/HelloWorld
        public string Get()
        {
            return "Hello World, I'm an API!";
        }

        // GET api/HelloWorld/id
        public string Get(string id)
        {
            return "Hello, " + id;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
