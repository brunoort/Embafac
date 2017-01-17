using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Embafac.Pcp.Entidades.Models
{
    public class Caminhao
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        public virtual TipoVeiculo TipoVeiculo { get; set; }

        public virtual string Placa { get; set; }
        public virtual int CapacidadeEntregaTamborEmPe { get; set; }
        public virtual int CapacidadeEntregaTamborAltoDeitado { get; set; }
        public virtual int CapacidadeEntregaTamborBaixoDeitado { get; set; }
        public virtual int CapacidadeColetaTamborEmPe { get; set; }
        public virtual int CapacidadeColetaTamborAltoDeitado { get; set; }
        public virtual  int CapacidadeColetaTamborBaixoDeitado { get; set; }
    }
}
