using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoininvauditorium
    {
        public short Sucursal { get; set; }
        public DateTime Fecha { get; set; }
        public short? Linea { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioMostrador { get; set; }
        public decimal? Existencia { get; set; }
        public decimal? ConteoFisico { get; set; }
        public decimal? Diferencia { get; set; }
    }
}
