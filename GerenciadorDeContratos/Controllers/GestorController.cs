using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GerenciadorDeContratos.DAL;
using GerenciadorDeContratos.Models;

namespace GerenciadorDeContratos.Controllers
{
    public class GestorController : Controller
    {
        private ContratoContext db = new ContratoContext();

        // GET: Gestor
        public ActionResult Index()
        {
            return View(db.Gestores.ToList());
        }

        // GET: Gestor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gestor gestor = db.Gestores.Find(id);
            if (gestor == null)
            {
                return HttpNotFound();
            }
            return View(gestor);
        }

        // GET: Gestor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gestor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GestorID,nomeCompleto,enderecoCompleto,email,senha,dataNascimento,rg,cpf,ativo")] Gestor gestor)
        {
            if (ModelState.IsValid)
            {
                db.Gestores.Add(gestor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gestor);
        }

        // GET: Gestor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gestor gestor = db.Gestores.Find(id);
            if (gestor == null)
            {
                return HttpNotFound();
            }
            return View(gestor);
        }

        // POST: Gestor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GestorID,nomeCompleto,enderecoCompleto,email,senha,dataNascimento,rg,cpf,ativo")] Gestor gestor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gestor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gestor);
        }

        // GET: Gestor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gestor gestor = db.Gestores.Find(id);
            if (gestor == null)
            {
                return HttpNotFound();
            }
            return View(gestor);
        }

        // POST: Gestor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gestor gestor = db.Gestores.Find(id);
            db.Gestores.Remove(gestor);
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
