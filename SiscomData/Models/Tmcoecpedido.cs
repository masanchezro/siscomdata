using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoecpedido
    {
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public short Sucursal { get; set; }
        public DateTime FechaRuteo { get; set; }
        public string PrioridadServicio { get; set; }
        public decimal ImporteTotal { get; set; }
        public string Observaciones { get; set; }
        public bool Cancelado { get; set; }
        public bool Ruteado { get; set; }
        public bool Facturado { get; set; }
        public bool PendienteFacturacion { get; set; }
        public int FormaPago { get; set; }
        public string UsuarioCancela { get; set; }
        public string ObservacionesCancela { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int? MotivoCancelaId { get; set; }
        public int? FolioConsumible { get; set; }
        public string EstatusServicio { get; set; }
        public bool PendienteNc { get; set; }
        public decimal CantEfectivo { get; set; }
        public decimal CantTarjeta { get; set; }
        public int TipoNc { get; set; }
        public string RefFormaPago { get; set; }
        public bool PagoPorTransferencia { get; set; }
        public string ConektaRef { get; set; }
        public string MagentoId { get; set; }
        public string NoGuia { get; set; }
        public bool FacturaEnviada { get; set; }
    }
}
