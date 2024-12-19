using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Odgkh05
    {
        public short Suc { get; set; }
        public DateTime FechaRuteo { get; set; }
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public string Servicio { get; set; }
        public string Volante { get; set; }
        public int? Ruta { get; set; }
        public int? Recetas { get; set; }
        public decimal? ImpRecetas { get; set; }
        public decimal? ImpSee { get; set; }
        public string Observac1 { get; set; }
        public string Observac2 { get; set; }
        public string Cancelado { get; set; }
        public string Definitivo { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Facturado { get; set; }
        public string ClavePendiente { get; set; }
        public string FormaPago { get; set; }
        public string CampoAux { get; set; }
        public string CancelaUsuario { get; set; }
        public int? CtePatiosOxidom { get; set; }
        public int? CodPos { get; set; }
        public string FiltroRutas { get; set; }
        public string TourSolver1 { get; set; }
        public string TourSolver2 { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Extra4 { get; set; }
        public string Extra5 { get; set; }
    }
}
