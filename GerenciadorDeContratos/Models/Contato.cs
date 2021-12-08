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
        [Required]
        [Display(Name = "ID do contato")]
        public int ContatoID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Funcao")]
        public string funcao { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de nascimento")]
        public DateTime dataNascimento { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Endereco da empresa")]
        public string enderecoEmpresa { get; set; }

        [Required]
        [Display(Name = "Numero")]
        public int numero { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Complemento")]
        public string complemento { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Estado")]
        public string estado { get; set; }

        [Required]
        [Display(Name = "CEP")]
        public int cep { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public int telefone { get; set; }

        [Required]
        [Display(Name = "Celular")]
        public int celular { get; set; }

        [Display(Name = "Fax")]
        public string fax { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Telefone comercial")]
        public int telefoneComercial { get; set; }

        public virtual ICollection<Contratado> Contratados { get; set; }

        public virtual ICollection<Contratante> Contratantes { get; set; }

    }
}