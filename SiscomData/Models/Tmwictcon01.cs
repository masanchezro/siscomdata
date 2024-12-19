using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmwictcon01
    {
        public long IdContacto { get; set; }
        public short? Sucursal { get; set; }
        public DateTime? Fecha { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string DescPais { get; set; }
        public string DescEdo { get; set; }
        public string Empresa { get; set; }
        public string Area { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Delegacion { get; set; }
        public string Cp { get; set; }
        public string Telefono { get; set; }
        public string Interes { get; set; }
        public string DescAreaInt { get; set; }
        public string Otra { get; set; }
        public string TipoSolicitud { get; set; }
        public string DescTiposolicitud { get; set; }
        public string Comentario { get; set; }
        public string Respuesta { get; set; }
        public DateTime? Fecharesp { get; set; }
        public string Usuario { get; set; }
    }
}
