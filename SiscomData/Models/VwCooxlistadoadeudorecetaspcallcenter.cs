using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxlistadoadeudorecetaspcallcenter
    {
        public int Delegacion { get; set; }
        public int Sucursal { get; set; }
        public string Instituto { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
        public string MesAnio { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string TipoServicio { get; set; }
        public double? ImpAdeudo { get; set; }
        public int TotalRecetas { get; set; }
        public string Referencia { get; set; }
        public string Estatus { get; set; }
    }
}
