using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Atnd0.Models;

namespace Atnd0.Controllers
{
    public class AtndController : Controller
    {
        private AtndDB db = new AtndDB();

        // GET: /Atnd/List
        public ActionResult List()
        {
            return View(db.Attendees.ToList());
        }

        // GET: /Atnd/Regist
        public ActionResult Regist()
        {
            return View();
        }

        // POST: /Atnd/Regist
        [HttpPost]
        public ActionResult Regist(Attendee attendee)
        {
            if (ModelState.IsValid)
            {
                db.Attendees.Add(attendee);
                db.SaveChanges();
                return RedirectToAction("Complete");
            }

            return View(attendee);
        }

        public ActionResult Complete()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}