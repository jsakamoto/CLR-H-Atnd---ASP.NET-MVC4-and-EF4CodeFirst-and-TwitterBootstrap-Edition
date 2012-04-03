using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Atnd0.Models;

namespace Atnd0.Controllers
{
    public class MyAPIController : ApiController
    {
        private AtndDB db = new AtndDB();

        // GET /api/myapi
        public IQueryable<Attendee> Get()
        {
            return db.Attendees.AsQueryable();
        }
    }
}
