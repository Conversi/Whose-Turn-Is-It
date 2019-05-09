using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Whose_Turn_Is_It.Data;
using Whose_Turn_Is_It.Models;

namespace Whose_Turn_Is_It.Controllers
{
    public class CreateJobController : Controller
    {
        private WhoseContext db = new WhoseContext();

        // GET: CreateJob
        [Authorize]
        public ActionResult Index()
        {
            return View(db.createJobs.ToList());
        }

        // GET: CreateJob/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateJob createJob = db.createJobs.Find(id);
            if (createJob == null)
            {
                return HttpNotFound();
            }
            return View(createJob);
        }

        // GET: CreateJob/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateJob/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TaskName,TaskDescription,TaskHelpers")] CreateJob createJob)
        {
            if (ModelState.IsValid)
            {
                db.createJobs.Add(createJob);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(createJob);
        }

        // GET: CreateJob/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateJob createJob = db.createJobs.Find(id);
            if (createJob == null)
            {
                return HttpNotFound();
            }
            return View(createJob);
        }

        // POST: CreateJob/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TaskName,TaskDescription,TaskHelpers")] CreateJob createJob)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createJob).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createJob);
        }

        // GET: CreateJob/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateJob createJob = db.createJobs.Find(id);
            if (createJob == null)
            {
                return HttpNotFound();
            }
            return View(createJob);
        }

        // POST: CreateJob/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CreateJob createJob = db.createJobs.Find(id);
            db.createJobs.Remove(createJob);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
