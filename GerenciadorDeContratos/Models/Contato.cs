using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.Models
{
    public class Contato
    {
        public int ContatoID { get; set; }

        public string nome { get; set; }

        public string funcao { get; set; }

        public DateTime dataNascimento { get; set; }

        public string enderecoEmpresa { get; set; }

        public int numero { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public int cep { get; set; }

        public int telefone { get; set; }

        public int celular { get; set; }

        public string fax { get; set; }

        public string email { get; set; }

        public int telefoneComercial { get; set; }

        public virtual ICollection<Contratado> Contratados { get; set; }

        public virtual ICollection<Contratante> Contratantes { get; set; }

    }
}