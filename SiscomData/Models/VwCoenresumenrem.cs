using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenresumenrem
    {
        public short Area { get; set; }
        public int SucDestino { get; set; }
        public string NombreSuc { get; set; }
        public int Remision { get; set; }
        public string TipoOrigen { get; set; }
        public DateTime? Fecharemision { get; set; }
        public string Estatus { get; set; }
        public int? Cantidad { get; set; }
        public string Distribucion { get; set; }
        public string Concluida { get; set; }
        public DateTime? FechaRecibida { get; set; }
        public int DiasTransito { get; set; }
        public int DiasRecepcion { get; set; }
        public int DiasTranscurridos { get; set; }
    }
}
