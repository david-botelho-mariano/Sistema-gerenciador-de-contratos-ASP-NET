using GerenciadorDeContratos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;
using GerenciadorDeContratos.Models;
using System.Net;

namespace GerenciadorDeContratos.Controllers
{
    public class HomeController : Controller

    {
        private ContratoContext db = new ContratoContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AreaRestrita()
        {
            return View();
        }

        public ActionResult Ajuda()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult DetalharContrato(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = db.Contratos.Find(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        public ActionResult VisualizarContratos()
        {
            var contratos = db.Contratos.Include(c => c.Contratado).Include(c => c.Contratante);
            Console.Out.WriteLine(contratos.ToList());
            return View(contratos.ToList());
        }
    }
}