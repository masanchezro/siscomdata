using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Encuestum
    {
        public double? Id { get; set; }
        public int? Campaña { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public int? Pedido { get; set; }
        public int? Cliente { get; set; }
        public string Nombre { get; set; }
        public short? Sucursal { get; set; }
        public short? Clinica { get; set; }
        public short? Delegacion { get; set; }
        public string NombreClinica { get; set; }
        public DateTime? Fecha { get; set; }
        public short? NoPregunta { get; set; }
    }
}
