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
        public int PessoaJuridicaID { get; set; }

        [Display(Name = "Razao social")]
        public string razaoSocial { get; set; }

        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }

        [Display(Name = "Inscricao municipal")]
        public int inscricaoMunicipal { get; set; }

        [Display(Name = "Inscricao estadual")]
        public int inscricaoEstadual { get; set; }

        [Display(Name = "Porta da empresa")]
        public int porteDaEmpresa { get; set; }

        [Display(Name = "Ramo de atividade")]
        public string ramoDeAtividade { get; set; }

        [Display(Name = "Optante pelo simples")]
        public string optantePeloSimples { get; set; }

        [Display(Name = "Nome fantasia")]
        public string nomeFantasia { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }

        public virtual Contato Contato { get; set; }

        [Display(Name = "ID do Contato")]
        public int? ContatoID { get; set; }

    }
}