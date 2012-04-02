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

        // GET: /Atnd/
        public ActionResult Index()
        {
            return View(db.Attendees.ToList());
        }

        // GET: /Atnd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Atnd/Create
        [HttpPost]
        public ActionResult Create(Attendee attendee)
        {
            if (ModelState.IsValid)
            {
                db.Attendees.Add(attendee);
                db.SaveChanges();
                return RedirectToAction("Finish");
            }

            return View(attendee);
        }

        public ActionResult Finish()
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