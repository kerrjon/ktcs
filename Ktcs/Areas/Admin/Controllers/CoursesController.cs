using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ktcs.Classes;
using Ktcs.Datamodel;

namespace Ktcs.Areas.Admin.Controllers
{
    public class CoursesController : Controller
    {
        private KtcsDbContext db = new KtcsDbContext();

        // GET: Admin/Courses
        public async Task<ActionResult> Index()
        {
      //var courses = db.Courses.Include(c => c.BasePrice).Include(c => c.CourseTypeDetail);
      var courses = db.Courses;
      return View(await courses.ToListAsync());
        }

        // GET: Admin/Courses/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = await db.Courses.FindAsync(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return PartialView(course);
        }

        // GET: Admin/Courses/Create
        public ActionResult Create()
        {
            //ViewBag.basePriceID = new SelectList(db.BasePrices, "BasePriceID", "BaseDescription");
            //ViewBag.courseTypeDetailID = new SelectList(db.CourseTypeDetails, "CourseTypeDetailID", "CourseTypeDetail1");
            return View();
        }

        // POST: Admin/Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "courseNumber,title,description,prereq,duration,courseTypeDetailID,comments,inscomments,overview,basePriceID,courseware,coursewarevendor,coursewarecost,coursewarenotes,datecreated,lastupdate,instructorNotes,vendorwebsite,isvisable,visibleInFlyout")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            //ViewBag.basePriceID = new SelectList(db.BasePrices, "BasePriceID", "BaseDescription", course.basePriceID);
            //ViewBag.courseTypeDetailID = new SelectList(db.CourseTypeDetails, "CourseTypeDetailID", "CourseTypeDetail1", course.courseTypeDetailID);
            return View(course);
        }

        // GET: Admin/Courses/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = await db.Courses.FindAsync(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            //ViewBag.basePriceID = new SelectList(db.BasePrices, "BasePriceID", "BaseDescription", course.basePriceID);
            //ViewBag.courseTypeDetailID = new SelectList(db.CourseTypeDetails, "CourseTypeDetailID", "CourseTypeDetail1", course.courseTypeDetailID);
            return View(course);
        }

        // POST: Admin/Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "courseNumber,title,description,prereq,duration,courseTypeDetailID,comments,inscomments,overview,basePriceID,courseware,coursewarevendor,coursewarecost,coursewarenotes,datecreated,lastupdate,instructorNotes,vendorwebsite,isvisable,visibleInFlyout")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            //ViewBag.basePriceID = new SelectList(db.BasePrices, "BasePriceID", "BaseDescription", course.basePriceID);
            //ViewBag.courseTypeDetailID = new SelectList(db.CourseTypeDetails, "CourseTypeDetailID", "CourseTypeDetail1", course.courseTypeDetailID);
            return View(course);
        }

        // GET: Admin/Courses/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = await db.Courses.FindAsync(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Admin/Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            Course course = await db.Courses.FindAsync(id);
            db.Courses.Remove(course);
            await db.SaveChangesAsync();
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
