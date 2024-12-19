using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoexpprof
    {
        public Tdcoexpprof()
        {
            Tdcoexpprofseries = new HashSet<Tdcoexpprofseries>();
        }

        public int Sucursal { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Um { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioVenta { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Importe { get; set; }
        public string Envio { get; set; }
        public string Farancelaria { get; set; }
        public bool? Facturado { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int? Cilindros { get; set; }
        public bool? EsMuestra { get; set; }
        public decimal? CantidadTigie { get; set; }
        public decimal? PrecioTigie { get; set; }
        public string Umtigie { get; set; }
        public bool? UsaConversion { get; set; }

        public virtual Tmcoexpprof Tmcoexpprof { get; set; }
        public virtual ICollection<Tdcoexpprofseries> Tdcoexpprofseries { get; set; }
    }
}
