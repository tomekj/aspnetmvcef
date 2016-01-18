using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SystemEwidencjonowaniaAR.Models;

namespace SystemEwidencjonowaniaAR.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = ApplicationDbContext.Create();
        // GET: KategriaZasobu
        public ActionResult Index()
        {
            return View(db.Category.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Category kategoria = db.Category.Find(id);
            ViewBag.Text = db.Category.ToList();
            if (kategoria == null)
                return HttpNotFound();
            return View(kategoria);
        }

        // GET: Item/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Category")]Category kategoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Category.Add(kategoria);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(kategoria);
            }
            catch
            {
                return View();
            }
        }

        // GET: KategriaZasobu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KategriaZasobu/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KategriaZasobu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KategriaZasobu/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
