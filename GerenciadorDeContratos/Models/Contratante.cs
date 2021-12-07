using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.Models
{
    public class Contratante : PessoaJuridica
    {
        public int ContratanteID { get; set; }

        //[Column("ContatoIdContratante")]
        [Column("ContatoID")]
        public int? ContatoID { get; set; }
    }
}