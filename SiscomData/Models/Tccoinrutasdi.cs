using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinrutasdi
    {
        public short Ruta { get; set; }
        public string NomRuta { get; set; }
        public short Sucursal { get; set; }
        public int SucursalDes { get; set; }
        public short? GuiaSuc { get; set; }
        public string DiaPago { get; set; }
        public decimal? Distancia { get; set; }
        public string TipoAccion { get; set; }
    }
}
