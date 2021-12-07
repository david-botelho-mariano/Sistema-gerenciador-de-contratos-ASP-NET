using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.Models
{
    public class Contratante : PessoaJuridica
    {
        [Display(Name = "ID do contratante")]
        public int ContratanteID { get; set; }
        
    }
}