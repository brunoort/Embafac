using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embafac.Pcp.Entidades.Models
{
    public class CarregamentoDescarregamento
    {
        public int Id { get; set; }

        public int IdPlanejamento { get; set; }

        public int Ordem { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Inicio { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Termino { get; set; }

        public Tipo Tipo { get; set; }
    }

   
}
