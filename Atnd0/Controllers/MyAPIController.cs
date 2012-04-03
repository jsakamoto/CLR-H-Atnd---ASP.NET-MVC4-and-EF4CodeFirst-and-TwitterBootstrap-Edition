using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace Atnd0.Controllers
{
    public class MyAPIController : ApiController
    {
        // GET /api/myapi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET /api/myapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST /api/myapi
        public void Post(string value)
        {
        }

        // PUT /api/myapi/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/myapi/5
        public void Delete(int id)
        {
        }
    }
}
