using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxcliente
    {
        public long? RowNumber { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Afiliacion { get; set; }
        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public string NombreCompleto { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Nombre { get; set; }
        public string Curp { get; set; }
        public string Clave { get; set; }
        public short Delegacion { get; set; }
        public short Clinica { get; set; }
        public string NombreClinDel { get; set; }
        public bool Cancelado { get; set; }
        public string AgrMedico { get; set; }
    }
}
