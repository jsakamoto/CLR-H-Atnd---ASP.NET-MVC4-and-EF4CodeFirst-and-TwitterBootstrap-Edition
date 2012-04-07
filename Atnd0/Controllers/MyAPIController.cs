using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Atnd0.Models;

namespace Atnd0.Controllers
{
    public class MyApiController : ApiController
    {
        // GET /api/attendees
        public IQueryable<Attendee> Get()
        {
            return new AtndDB().Attendees;
        }
    }
}
