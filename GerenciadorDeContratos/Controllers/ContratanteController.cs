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
    public class ContratanteController : Controller
    {
        private ContratoContext db = new ContratoContext();

        // GET: Contratante
        public ActionResult Index()
        {
            return View(db.Contratantes.ToList());
        }

        // GET: Contratante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contratante contratante = db.Contratantes.Find(id);
            if (contratante == null)
            {
                return HttpNotFound();
            }
            return View(contratante);
        }

        // GET: Contratante/Create
        public ActionResult Create()
        {
            ViewBag.ContatoID = new SelectList(db.Contatos, "ContatoID", "email");
            return View();
        }

        // POST: Contratante/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContratanteID,ContatoID,razaoSocial,cnpj,inscricaoMunicipal,inscricaoEstadual,porteDaEmpresa,ramoDeAtividade,optantePeloSimples,nomeFantasia")] Contratante contratante)
        {
            if (ModelState.IsValid)
            {
                db.Contratantes.Add(contratante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contratante);
        }

        // GET: Contratante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contratante contratante = db.Contratantes.Find(id);
            if (contratante == null)
            {
                return HttpNotFound();
            }

            ViewBag.ContatoID = new SelectList(db.Contatos, "ContatoID", "email");

            return View(contratante);
        }

        // POST: Contratante/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContratanteID,ContatoID,razaoSocial,cnpj,inscricaoMunicipal,inscricaoEstadual,porteDaEmpresa,ramoDeAtividade,optantePeloSimples,nomeFantasia")] Contratante contratante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contratante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contratante);
        }

        // GET: Contratante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contratante contratante = db.Contratantes.Find(id);
            if (contratante == null)
            {
                return HttpNotFound();
            }
            return View(contratante);
        }

        // POST: Contratante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contratante contratante = db.Contratantes.Find(id);
            db.Contratantes.Remove(contratante);
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
