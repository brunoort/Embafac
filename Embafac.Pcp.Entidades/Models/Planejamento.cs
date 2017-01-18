using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embafac.Pcp.Entidades.Models
{
    public class Planejamento
    {
        public int Id { get; set; }

        public int IdCaminhao { get; set; }

        public int IdEmpresa { get; set; }

        //Horarios
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Chegada { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Saida { get; set; }
        
        public CarregamentoDescarregamento CarregamentoDescarregamento { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime DataPlanejamento { get; set; }

        public string Observacoes { get; set; }
    }

    
}
