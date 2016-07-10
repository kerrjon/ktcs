using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ktcs.Data;

namespace Ktcs.Areas.Admin.Controllers
{
    public class InstructorsController : Controller
    {
        private KtcsEntities db = new KtcsEntities();

        // GET: Admin/Instructors
        public async Task<ActionResult> Index()
        {
            return View(await db.Instructors.ToListAsync());
        }

        // GET: Admin/Instructors/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instructor instructor = await db.Instructors.FindAsync(id);
            if (instructor == null)
            {
                return HttpNotFound();
            }
            return PartialView(instructor);
        }

        // GET: Admin/Instructors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Instructors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "InstructorID,insfname,inslname,insaddress,inscity,insstate,inszip,insphone,insphone2,insemail,insemail2,insfax,inscountry,VendorID,password,insIndependent,insReferredBy,Keywords,resumeText,Skill1,Skill2,Skill3,Skill4,Skill5,Category1,Category2,Category3,notes,coursewareNotes")] Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                db.Instructors.Add(instructor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(instructor);
        }

        // GET: Admin/Instructors/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instructor instructor = await db.Instructors.FindAsync(id);
            if (instructor == null)
            {
                return HttpNotFound();
            }
            return View(instructor);
        }

        // POST: Admin/Instructors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "InstructorID,insfname,inslname,insaddress,inscity,insstate,inszip,insphone,insphone2,insemail,insemail2,insfax,inscountry,VendorID,password,insIndependent,insReferredBy,Keywords,resumeText,Skill1,Skill2,Skill3,Skill4,Skill5,Category1,Category2,Category3,notes,coursewareNotes")] Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instructor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(instructor);
        }

        // GET: Admin/Instructors/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instructor instructor = await db.Instructors.FindAsync(id);
            if (instructor == null)
            {
                return HttpNotFound();
            }
            return View(instructor);
        }

        // POST: Admin/Instructors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            Instructor instructor = await db.Instructors.FindAsync(id);
            db.Instructors.Remove(instructor);
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
