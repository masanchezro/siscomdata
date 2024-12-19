using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxdiapacEstcon
    {
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public int? SubTipoCte { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string NomClinica { get; set; }
        public short Delegacion { get; set; }
        public short Clinica { get; set; }
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
