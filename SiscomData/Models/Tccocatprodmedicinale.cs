using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocatprodmedicinale
    {
        public int CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string DenominacionGenerica { get; set; }
        public string DenominacionDistintiva { get; set; }
        public string Fabricante { get; set; }
        public string CondicionesEspTransp { get; set; }
        public string RegistroSanitario { get; set; }
        public string FormaFarmaceutica { get; set; }
        public int? FechaCaducidadMeses { get; set; }
    }
}
