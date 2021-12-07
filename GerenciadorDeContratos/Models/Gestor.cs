using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.Models
{
    public class Gestor
    {
        public int GestorID { get; set; }

        public string nomeCompleto { get; set; }

        public string enderecoCompleto { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public DateTime dataNascimento { get; set; }

        public int rg { get; set; }

        public string cpf { get; set; }

        public int ativo { get; set; }

    }
}