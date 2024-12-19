using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoinmov1
    {
        public Thcoinmov1()
        {
            Tdcoinmovscods = new HashSet<Tdcoinmovscod>();
            Tdcoinmovscodseries = new HashSet<Tdcoinmovscodseries>();
            Thcoinmovspedgas = new HashSet<Thcoinmovspedga>();
        }

        public long IdConsecutivoMov { get; set; }
        public short Almacen { get; set; }
        public DateTime FechaMov { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int NotaCredito { get; set; }
        public string Observaciones { get; set; }
        public string TipoNotaCred { get; set; }
        public int? Pedido { get; set; }
        public string FacturaRemision { get; set; }
        public string NumRemision { get; set; }
        public int? NumRefactura { get; set; }
        public short? IdTipoIva { get; set; }
        public string FormaPago { get; set; }
        public string DoctoFormaPago { get; set; }
        public string CondicionPago { get; set; }
        public int ClienteSuc { get; set; }
        public string Rfc { get; set; }
        public bool? Transito { get; set; }
        public bool Reparto { get; set; }
        public short? Ejecutivo { get; set; }
        public string MotivoNc { get; set; }
        public string Paquete { get; set; }
        public decimal? TipoCambio { get; set; }
        public bool? CveImpresion { get; set; }
        public bool? PedidoGas { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Iuuid { get; set; }

        public virtual Tccogrsuc AlmacenNavigation { get; set; }
        public virtual ICollection<Tdcoinmovscod> Tdcoinmovscods { get; set; }
        public virtual ICollection<Tdcoinmovscodseries> Tdcoinmovscodseries { get; set; }
        public virtual ICollection<Thcoinmovspedga> Thcoinmovspedgas { get; set; }
    }
}
