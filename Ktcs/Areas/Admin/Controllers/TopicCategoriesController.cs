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
    public class TopicCategoriesController : Controller
    {
        private KtcsEntities db = new KtcsEntities();

        // GET: Admin/TopicCategories
        public async Task<ActionResult> Index()
        {
            var topicCategories = db.TopicCategories.Include(t => t.Topic);
            return View(await topicCategories.ToListAsync());
        }

        // GET: Admin/TopicCategories/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopicCategory topicCategory = await db.TopicCategories.FindAsync(id);
            if (topicCategory == null)
            {
                return HttpNotFound();
            }
            return View(topicCategory);
        }

        // GET: Admin/TopicCategories/Create
        public ActionResult Create()
        {
            ViewBag.topicId = new SelectList(db.Topics, "topicId", "topic1");
            return View();
        }

        // POST: Admin/TopicCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "topicCategory1,topicCategoryID,topicId")] TopicCategory topicCategory)
        {
            if (ModelState.IsValid)
            {
                db.TopicCategories.Add(topicCategory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.topicId = new SelectList(db.Topics, "topicId", "topic1", topicCategory.topicId);
            return View(topicCategory);
        }

        // GET: Admin/TopicCategories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopicCategory topicCategory = await db.TopicCategories.FindAsync(id);
            if (topicCategory == null)
            {
                return HttpNotFound();
            }
            ViewBag.topicId = new SelectList(db.Topics, "topicId", "topic1", topicCategory.topicId);
            return View(topicCategory);
        }

        // POST: Admin/TopicCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "topicCategory1,topicCategoryID,topicId")] TopicCategory topicCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(topicCategory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.topicId = new SelectList(db.Topics, "topicId", "topic1", topicCategory.topicId);
            return View(topicCategory);
        }

        // GET: Admin/TopicCategories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopicCategory topicCategory = await db.TopicCategories.FindAsync(id);
            if (topicCategory == null)
            {
                return HttpNotFound();
            }
            return View(topicCategory);
        }

        // POST: Admin/TopicCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TopicCategory topicCategory = await db.TopicCategories.FindAsync(id);
            db.TopicCategories.Remove(topicCategory);
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
