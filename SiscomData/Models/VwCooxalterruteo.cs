using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxalterruteo
    {
        public DateTime? Fecha { get; set; }
        public string Servicio { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Contrato { get; set; }
        public int Propiedad { get; set; }
        public string Calle { get; set; }
        public string Numext { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Codpos { get; set; }
        public string Observ { get; set; }
    }
}
