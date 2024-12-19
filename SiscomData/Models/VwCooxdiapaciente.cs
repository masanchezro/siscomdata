using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxdiapaciente
    {
        public int? SubTipoCte { get; set; }
        public string Pertenencia { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Afiliacion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string NomClinica { get; set; }
        public short Delegacion { get; set; }
        public short Clinica { get; set; }
        public decimal Precio { get; set; }
        public int FolioBaja { get; set; }
        public bool Cancelado { get; set; }
        public int? Multi { get; set; }
        public int Codigo { get; set; }
        public string Servicio { get; set; }
    }
}
