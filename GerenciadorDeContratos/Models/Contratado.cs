using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.Models
{
    public class Contratado : PessoaJuridica
    {
        [Display(Name = "ID do contratado")]
        public int ContratadoID { get; set; }

    }
}