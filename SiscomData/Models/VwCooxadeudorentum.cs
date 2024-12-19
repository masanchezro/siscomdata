using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxadeudorentum
    {
        public int Cliente { get; set; }
        public string FormaCobro { get; set; }
        public int Codigo { get; set; }
        public int? FolioAltaRenta { get; set; }
        public string NombreCte { get; set; }
        public int? DiasRenta { get; set; }
        public short DiasProd { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaUltPago { get; set; }
        public DateTime? CteFbaja { get; set; }
        public DateTime? FbajaEquipo { get; set; }
        public DateTime? FechaBaja { get; set; }
        public decimal? Importe { get; set; }
        public short? CantEquipo { get; set; }
        public DateTime? AltaCliente { get; set; }
        public string Formapago { get; set; }
        public string NombreInst { get; set; }
        public string NombreClinica { get; set; }
        public string TieneEquipo { get; set; }
        public int CodigoEnvases { get; set; }
        public decimal? Deposito { get; set; }
        public decimal PrecioDia { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
        public string Ejecutivo { get; set; }
    }
}
