using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GerenciadorDeContratos.Models
{
    public class Contrato
    {
        public int ContratoID { get; set; }

        public int ContratanteID { get; set; }

        public int ContratadoID { get; set; }

        public int numeroContrato { get; set; }

        public string objetoContrato{ get; set; }

        public int vigenciaContrato { get; set; }

        public virtual Contratante Contratante { get; set; }
    
        public virtual Contratado Contratado { get; set; }


    }

}