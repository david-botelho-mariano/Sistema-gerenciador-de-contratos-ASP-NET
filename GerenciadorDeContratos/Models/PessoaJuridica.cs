using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace GerenciadorDeContratos.Models
{
    public abstract class PessoaJuridica
    {
        [Required]
        public int PessoaJuridicaID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Razao social")]
        public string razaoSocial { get; set; }
        
        [Required]
        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }

        [Required]
        [Display(Name = "Inscricao municipal")]
        public int inscricaoMunicipal { get; set; }

        [Required]
        [Display(Name = "Inscricao estadual")]
        public int inscricaoEstadual { get; set; }

        [Required]
        [Display(Name = "Porte da empresa")]
        public int porteDaEmpresa { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Ramo de atividade")]
        public string ramoDeAtividade { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Optante pelo simples")]
        public string optantePeloSimples { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Nome fantasia")]
        public string nomeFantasia { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }

        public virtual Contato Contato { get; set; }

        //[Required]
        //CAUSA ERRO 
        [Display(Name = "ID do Contato")]
        public int? ContatoID { get; set; }

    }
}