using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.Models
{
    public class Gestor
    {
        [Display(Name = "ID do gestor")]
        public int GestorID { get; set; }

        [Display(Name = "Nome completo")]
        public string nomeCompleto { get; set; }

        [Display(Name = "Endereco completo")]
        public string enderecoCompleto { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Senha")]
        public string senha { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime dataNascimento { get; set; }

        [Display(Name = "RG")]
        public int rg { get; set; }

        [Display(Name = "CPF")]
        public string cpf { get; set; }

        [Display(Name = "Ativo")]
        public int ativo { get; set; }

    }
}