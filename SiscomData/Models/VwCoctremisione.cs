using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoctremisione
    {
        public int Remision { get; set; }
        public int? Idcabecera { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal CantRemision { get; set; }
        public decimal CantFacturada { get; set; }
        public decimal CantDevuelta { get; set; }
        public int Cliente { get; set; }
        public string RazonSocial { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public decimal Iva { get; set; }
        public int EnvasesRemision { get; set; }
    }
}
