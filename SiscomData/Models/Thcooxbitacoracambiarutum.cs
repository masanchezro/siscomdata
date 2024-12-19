using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcooxbitacoracambiarutum
    {
        public long IdBitacora { get; set; }
        public int? Sucursal { get; set; }
        public int? Pedido { get; set; }
        public int? Cliente { get; set; }
        public DateTime? FechaRuteoAnt { get; set; }
        public int? AlmacenAnt { get; set; }
        public int? RutaAnt { get; set; }
        public int? OperadorAnt { get; set; }
        public int? UnidadAnt { get; set; }
        public int? TurnoAnt { get; set; }
        public DateTime? FechaRuteo { get; set; }
        public int? Almacen { get; set; }
        public int? Operador { get; set; }
        public int? Ruta { get; set; }
        public int? Unidad { get; set; }
        public int? Turno { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
