using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxequiposyepen
    {
        public DateTime Fecha { get; set; }
        public short Sucursal { get; set; }
        public short Turno { get; set; }
        public short Unidad { get; set; }
        public short Ruta { get; set; }
        public int? Operardor { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short? CantidadSal { get; set; }
        public string SeriesSal { get; set; }
        public short Grupo { get; set; }
    }
}
