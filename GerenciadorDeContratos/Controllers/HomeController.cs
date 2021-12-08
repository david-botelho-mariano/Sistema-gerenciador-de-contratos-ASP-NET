using GerenciadorDeContratos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;
using GerenciadorDeContratos.Models;
using System.Net;

using System.Data.SqlClient;
using System.Text;
using System.Web.Http;

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
            return View(contratos.ToList().Where(contrato => contrato.ativo == "sim"));
        }

        public ActionResult contarContratosAtivos()
        {
            string msgErro = "";

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GerenciadorDeContratos;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();

                    String sql = "SELECT COUNT(ativo) FROM Contrato WHERE ativo = 'sim'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int qtdContratosAtivos = reader.GetInt32(0);
                                return Content(qtdContratosAtivos.ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                msgErro = e.ToString();
            }

            return Content(msgErro);
        }

        public ActionResult contarContratosInativos()
        {
            string msgErro = "";

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GerenciadorDeContratos;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();

                    String sql = "SELECT COUNT(ativo) FROM Contrato WHERE ativo = 'nao'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int qtdContratosInativos = reader.GetInt32(0);
                                return Content(qtdContratosInativos.ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                msgErro = e.ToString();
            }

            return Content(msgErro);
        }

        public ActionResult Autenticar([FromBody]string email, [FromBody]string senha)
        {
            string msgErro = "";

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GerenciadorDeContratos;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();

                    String sql = "SELECT * FROM Gestor WHERE (ativo = 'sim') and (email = '" + email + "') and (senha = '" + senha + "')";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return View("Dashboard");
                            }

                            else
                            {
                                return View("AreaRestrita");
                            }

                        }
                    }
                }
            }
            catch (SqlException e)
            {
                msgErro = e.ToString();
            }

            return Content(msgErro);
        }
    }
    
}