using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxlistadoreceta
    {
        public int? IdCapRecetas { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Afiliacion { get; set; }
        public string Direccion { get; set; }
        public int? Dias { get; set; }
        public decimal Precio { get; set; }
        public short Delegacion { get; set; }
        public short Unidad { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string TipoCaptura { get; set; }
        public int? SubTipoCte { get; set; }
        public string TipoServicio { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int FolioBaja { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string DpfechaFin { get; set; }
        public string DpfechaInicio { get; set; }
        public int FolioFactura { get; set; }
    }
}
