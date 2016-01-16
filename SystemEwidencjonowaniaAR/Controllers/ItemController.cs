﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SystemEwidencjonowaniaAR.Context;
using SystemEwidencjonowaniaAR.Models;

namespace SystemEwidencjonowaniaAR.Controllers
{
    public class ItemController : Controller
    {
        private ItemContext db = new ItemContext();
        
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.Index = "GET: Item";
            return View(db.Items.ToList());
        }

        // GET: Item/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Item item = db.Items.Find(id);
            if (item == null)
                return HttpNotFound();
            return View(item);
        }

        // GET: Item/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult Create(Item item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Items.Add(item);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(item);
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Item item = db.Items.Find(id);
            if (item == null)
                return HttpNotFound();
            return View(item);
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult Edit(Item item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                    
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Item/Delete/5
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
