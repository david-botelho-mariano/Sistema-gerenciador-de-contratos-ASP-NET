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
        [Required]
        [Display(Name = "ID do gestor")]
        public int GestorID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Nome completo")]
        public string nomeCompleto { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Endereco completo")]
        public string enderecoCompleto { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Senha")]
        public string senha { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de nascimento")]
        public DateTime dataNascimento { get; set; }

        [Required]
        [Display(Name = "RG")]
        public int rg { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string cpf { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(3)]
        [Display(Name = "Ativo")]
        public string ativo { get; set; }

    }
}