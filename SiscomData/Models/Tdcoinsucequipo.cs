using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinsucequipo
    {
        public int IdSucEquipo { get; set; }
        public short Sucursal { get; set; }
        public int Codigo { get; set; }
        public short SucCte { get; set; }
        public string TipoMovimiento { get; set; }
        public int FolioMovimiento { get; set; }
        public int Cantidad { get; set; }
        public string NoSerie { get; set; }
        public bool DispPatios { get; set; }
    }
}
