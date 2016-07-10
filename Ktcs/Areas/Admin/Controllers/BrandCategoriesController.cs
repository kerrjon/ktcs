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
    public class BrandCategoriesController : Controller
    {
        private KtcsEntities db = new KtcsEntities();

        // GET: Admin/BrandCategories
        public async Task<ActionResult> Index()
        {
            var brandCategories = db.BrandCategories.Include(b => b.Brand);
            return View(await brandCategories.ToListAsync());
        }

        // GET: Admin/BrandCategories/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrandCategory brandCategory = await db.BrandCategories.FindAsync(id);
            if (brandCategory == null)
            {
                return HttpNotFound();
            }
            return PartialView(brandCategory);
        }

        // GET: Admin/BrandCategories/Create
        public ActionResult Create()
        {
            ViewBag.BrandId = new SelectList(db.Brands, "brandId", "brand1");
            return View();
        }

        // POST: Admin/BrandCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "brandCategory1,BrandCategoryID,BrandId")] BrandCategory brandCategory)
        {
            if (ModelState.IsValid)
            {
                db.BrandCategories.Add(brandCategory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.BrandId = new SelectList(db.Brands, "brandId", "brand1", brandCategory.BrandId);
            return View(brandCategory);
        }

        // GET: Admin/BrandCategories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrandCategory brandCategory = await db.BrandCategories.FindAsync(id);
            if (brandCategory == null)
            {
                return HttpNotFound();
            }
            ViewBag.BrandId = new SelectList(db.Brands, "brandId", "brand1", brandCategory.BrandId);
            return View(brandCategory);
        }

        // POST: Admin/BrandCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "brandCategory1,BrandCategoryID,BrandId")] BrandCategory brandCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brandCategory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.BrandId = new SelectList(db.Brands, "brandId", "brand1", brandCategory.BrandId);
            return View(brandCategory);
        }

        // GET: Admin/BrandCategories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrandCategory brandCategory = await db.BrandCategories.FindAsync(id);
            if (brandCategory == null)
            {
                return HttpNotFound();
            }
            return View(brandCategory);
        }

        // POST: Admin/BrandCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            BrandCategory brandCategory = await db.BrandCategories.FindAsync(id);
            db.BrandCategories.Remove(brandCategory);
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
