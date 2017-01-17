using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embafac.Pcp.Entidades.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        ////Tempo previsto de carregamento para esta empresa
        ////Isso varia conforme a quantidade ou não? sempre será a mesma quantidade...
        //public DateTime TempoCarregamento { get; set; }

        //public DateTime TempoDescarregamento { get; set; }

        ////De onde para onde? o tempo é só dessa empresa
        //public DateTime TempoViagem { get; set; }
    }
}
