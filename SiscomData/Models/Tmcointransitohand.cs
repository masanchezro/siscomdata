using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcointransitohand
    {
        public short Almacen { get; set; }
        public int Codigo { get; set; }
        public string FolioCodeBar { get; set; }
        public string Descripcion { get; set; }
        public decimal? Empaque { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? CantidadEntrada { get; set; }
        public int Partida { get; set; }
        public int? Procesado { get; set; }
        public DateTime? Fechamov { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public int ClienteSuc { get; set; }
    }
}
