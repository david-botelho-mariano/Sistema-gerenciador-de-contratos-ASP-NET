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
        [Required]
        [Display(Name = "ID do contrato")]
        public int ContratoID { get; set; }

        [Required]
        [Display(Name = "ID do contratante")]
        public int ContratanteID { get; set; }

        [Required]
        [Display(Name = "ID do contratado")]
        public int ContratadoID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Objeto do contrato")]
        public string objetoContrato { get; set; }

        [Required]
        [Display(Name = "Vigencia do contrato")]
        public int vigenciaContrato { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(3)]
        [Display(Name = "Ativo")]
        public string ativo { get; set; }

        public virtual Contratante Contratante { get; set; }

        public virtual Contratado Contratado { get; set; }


    }

}