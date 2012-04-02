using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Atnd0.Models
{
    public class AtndDB : DbContext
    {
        public DbSet<Attendee> Attendees { get; set; }
    }
}