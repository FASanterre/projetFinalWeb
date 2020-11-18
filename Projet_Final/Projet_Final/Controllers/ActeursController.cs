using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projet_Final.Models;

namespace Projet_Final.Controllers
{
    public class ActeursController : Controller
    {
        private BDW56_424qEntities db = new BDW56_424qEntities();

        // GET: Acteurs
        public ActionResult Index()
        {
            return View(db.Acteurs.ToList());
        }

        // GET: Acteurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acteur acteur = db.Acteurs.Find(id);
            if (acteur == null)
            {
                return HttpNotFound();
            }
            return View(acteur);
        }

        // GET: Acteurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acteurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NoActeur,Nom,Sexe")] Acteur acteur)
        {
            if (ModelState.IsValid)
            {
                db.Acteurs.Add(acteur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(acteur);
        }

        // GET: Acteurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acteur acteur = db.Acteurs.Find(id);
            if (acteur == null)
            {
                return HttpNotFound();
            }
            return View(acteur);
        }

        // POST: Acteurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NoActeur,Nom,Sexe")] Acteur acteur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acteur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(acteur);
        }

        // GET: Acteurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Acteur acteur = db.Acteurs.Find(id);
            if (acteur == null)
            {
                return HttpNotFound();
            }
            return View(acteur);
        }

        // POST: Acteurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Acteur acteur = db.Acteurs.Find(id);
            db.Acteurs.Remove(acteur);
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
