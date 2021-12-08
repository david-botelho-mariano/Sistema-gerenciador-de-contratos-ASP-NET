using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.Models
{
    public class Contrato
    {
        [Display(Name = "ID do contrato")]
        public int ContratoID { get; set; }

        [Display(Name = "ID do contratante")]
        public int ContratanteID { get; set; }

        [Display(Name = "ID do contratado")]
        public int ContratadoID { get; set; }

        [Display(Name = "Objeto do contrato")]
        public string objetoContrato{ get; set; }

        [Display(Name = "Vigencia do contrato")]
        public int vigenciaContrato { get; set; }

        public virtual Contratante Contratante { get; set; }
    
        public virtual Contratado Contratado { get; set; }


    }

}