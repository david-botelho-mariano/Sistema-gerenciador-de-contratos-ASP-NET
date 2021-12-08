using GerenciadorDeContratos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;
using GerenciadorDeContratos.Models;
using System.Net;

using System;
using System.Data.SqlClient;
using System.Text;

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

        public ActionResult Temp()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();


                builder.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GerenciadorDeContratos;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "SELECT ativo FROM Gestor";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                                //Console.WriteLine(reader.GetString(0));

                                int qtdContratosAtivos = reader.GetInt32(0);
                                return Content(qtdContratosAtivos.ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
 
            return Content("Hi there!");
        }
    }
}