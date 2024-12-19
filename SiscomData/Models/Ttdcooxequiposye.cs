using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttdcooxequiposye
    {
        public short Sucursal { get; set; }
        public DateTime Fecha { get; set; }
        public short Ruta { get; set; }
        public short Turno { get; set; }
        public short Unidad { get; set; }
        public short Partida { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short? CantidadSal { get; set; }
        public string SeriesSal { get; set; }
        public short? CantidadEnt { get; set; }
        public string SeriesEnt { get; set; }
        public short? Nuevos { get; set; }
        public short? Cancelados { get; set; }
        public short? Llenos { get; set; }
        public short? Vacios { get; set; }
        public string Estatus { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int? Operador { get; set; }
        public short? Cambios { get; set; }
    }
}
