using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoenremisionesnodo
    {
        public Tdcoenremisionesnodo()
        {
            Tmcoenvremisiones = new HashSet<Tmcoenvremisione>();
        }

        public short Almacen { get; set; }
        public int Remision { get; set; }
        public DateTime FechaRemision { get; set; }
        public short NodoDestino { get; set; }
        public DateTime FechaNodoDestino { get; set; }
        public int Estatus { get; set; }

        public virtual ICollection<Tmcoenvremisione> Tmcoenvremisiones { get; set; }
    }
}
