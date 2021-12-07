using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.Models
{
    public class Contato
    {
        [Display(Name = "ID do contato")]
        public int ContatoID { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Funcao")]
        public string funcao { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime dataNascimento { get; set; }

        [Display(Name = "Endereco da empresa")]
        public string enderecoEmpresa { get; set; }

        [Display(Name = "Numero")]
        public int numero { get; set; }

        [Display(Name = "Complemento")]
        public string complemento { get; set; }

        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Display(Name = "CEP")]
        public int cep { get; set; }

        [Display(Name = "Telefone")]
        public int telefone { get; set; }

        [Display(Name = "Celular")]
        public int celular { get; set; }

        [Display(Name = "Fax")]
        public string fax { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Telefone comercial")]
        public int telefoneComercial { get; set; }

        public virtual ICollection<Contratado> Contratados { get; set; }

        public virtual ICollection<Contratante> Contratantes { get; set; }

    }
}