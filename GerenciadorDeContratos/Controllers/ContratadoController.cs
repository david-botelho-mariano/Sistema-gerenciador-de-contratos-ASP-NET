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
    public class ContratadoController : Controller
    {
        private ContratoContext db = new ContratoContext();

        // GET: Contratado
        public ActionResult Index()
        {
            return View(db.Contratados.ToList());
        }

        // GET: Contratado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contratado contratado = db.Contratados.Find(id);
            if (contratado == null)
            {
                return HttpNotFound();
            }
            return View(contratado);
        }

        // GET: Contratado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contratado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContratadoID,ContatoID,razaoSocial,cnpj,inscricaoMunicipal,inscricaoEstadual,porteDaEmpresa,ramoDeAtividade,optantePeloSimples,nomeFantasia")] Contratado contratado)
        {
            if (ModelState.IsValid)
            {
                db.Contratados.Add(contratado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contratado);
        }

        // GET: Contratado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contratado contratado = db.Contratados.Find(id);
            if (contratado == null)
            {
                return HttpNotFound();
            }
            return View(contratado);
        }

        // POST: Contratado/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContratadoID,ContatoID,razaoSocial,cnpj,inscricaoMunicipal,inscricaoEstadual,porteDaEmpresa,ramoDeAtividade,optantePeloSimples,nomeFantasia")] Contratado contratado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contratado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contratado);
        }

        // GET: Contratado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contratado contratado = db.Contratados.Find(id);
            if (contratado == null)
            {
                return HttpNotFound();
            }
            return View(contratado);
        }

        // POST: Contratado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contratado contratado = db.Contratados.Find(id);
            db.Contratados.Remove(contratado);
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
