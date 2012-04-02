using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atnd0.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string Email { get; set; }

        [Required, MaxLength(20)]
        public string TwitterID { get; set; }

        public bool beParty { get; set; }
    }
}