using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxpermiso
    {
        public int Id { get; set; }
        public int Cliente { get; set; }
        public DateTime FechaMov { get; set; }
        public string Psw { get; set; }
        public string Sistema { get; set; }
        public string Modulo { get; set; }
        public string Evento { get; set; }
        public int Cantidad { get; set; }
        public int? Pedido { get; set; }
        public string Estatus { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Observaciones { get; set; }
    }
}
