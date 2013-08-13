using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMusicCatalogue.Models.Context;

namespace WebMusicCatalogue.Controllers
{
    public class ProducerController : Controller
    {
        private music_catalogEntities db = new music_catalogEntities();

        //
        // GET: /Producer/

        public ActionResult Index()
        {
            return View(db.Producers.ToList());
        }

        //
        // GET: /Producer/Details/5

        public ActionResult Details(int id = 0)
        {
            Producer producer = db.Producers.Find(id);
            if (producer == null)
            {
                return HttpNotFound();
            }
            return View(producer);
        }

        //
        // GET: /Producer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Producer/Create

        [HttpPost]
        public ActionResult Create(Producer producer)
        {
            if (ModelState.IsValid)
            {
                db.Producers.Add(producer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(producer);
        }

        //
        // GET: /Producer/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Producer producer = db.Producers.Find(id);
            if (producer == null)
            {
                return HttpNotFound();
            }
            return View(producer);
        }

        //
        // POST: /Producer/Edit/5

        [HttpPost]
        public ActionResult Edit(Producer producer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(producer);
        }

        //
        // GET: /Producer/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Producer producer = db.Producers.Find(id);
            if (producer == null)
            {
                return HttpNotFound();
            }
            return View(producer);
        }

        //
        // POST: /Producer/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Producer producer = db.Producers.Find(id);
            db.Producers.Remove(producer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}