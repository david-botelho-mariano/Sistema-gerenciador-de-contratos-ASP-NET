using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.Models
{
    public abstract class PessoaJuridica
    {
        public int PessoaJuridicaID { get; set; }        

        //public virtual Contato Contato { get; set; }

        public string razaoSocial { get; set; }

        public string cnpj { get; set; }

        public int inscricaoMunicipal { get; set; }

        public int inscricaoEstadual { get; set; }

        public int porteDaEmpresa { get; set; }

        public string ramoDeAtividade { get; set; }

        public string optantePeloSimples { get; set; }

        public string nomeFantasia { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }

    }
}