using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenconsumo
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short? EnvCont { get; set; }
        public short? EnvProp { get; set; }
        public short? EnvProv { get; set; }
        public string FechaUltConsumo { get; set; }
        public int Enero { get; set; }
        public int Febrero { get; set; }
        public int Marzo { get; set; }
        public int Abril { get; set; }
        public int Mayo { get; set; }
        public int Junio { get; set; }
        public int Julio { get; set; }
        public int Agosto { get; set; }
        public int Septiembre { get; set; }
        public int Octubre { get; set; }
        public int Noviembre { get; set; }
        public int Diciembre { get; set; }
    }
}
