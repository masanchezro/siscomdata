using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class BorrarDoble
    {
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public short Sucursal { get; set; }
        public DateTime FechaRuteo { get; set; }
        public int TipoServicio { get; set; }
        public string PrioridadServicio { get; set; }
        public int Recetas { get; set; }
        public decimal ImporteRecetas { get; set; }
        public decimal ImporteSee { get; set; }
        public string Observaciones { get; set; }
        public bool Cancelado { get; set; }
        public bool Ruteado { get; set; }
        public bool Facturado { get; set; }
        public bool PendienteFacturacion { get; set; }
        public int FormaPago { get; set; }
        public string UsuarioCancela { get; set; }
        public string ObservacionesCancela { get; set; }
        public bool CancelacionEquipo { get; set; }
        public DateTime? FechaReactivacionEquipo { get; set; }
        public string ObservacionesReactivacion { get; set; }
        public int ClientePatios { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int? Ruta { get; set; }
        public int? CodPos { get; set; }
        public string FiltroRutas { get; set; }
        public string TourSolver1 { get; set; }
        public string TourSolver2 { get; set; }
        public int? TipoEquipo { get; set; }
        public int? MotivoCancelaId { get; set; }
        public string MarcaAlmacen { get; set; }
        public bool? VolanteImpreso { get; set; }
        public int? FolioConsumible { get; set; }
        public string AsignaTtr { get; set; }
        public int? NominaTtr { get; set; }
        public string Aseguradora { get; set; }
        public int? FolioTraspasoInst { get; set; }
        public DateTime? FechaProgInicio { get; set; }
        public DateTime? FechaProgTermino { get; set; }
        public DateTime? FechaAsigChofer { get; set; }
        public DateTime? FechaInicioServ { get; set; }
        public DateTime? FechaTerminoServ { get; set; }
        public string SubIndice { get; set; }
        public string EstatusServicio { get; set; }
        public bool PendienteNc { get; set; }
        public decimal CantEfectivo { get; set; }
        public decimal CantTarjeta { get; set; }
        public int TipoNc { get; set; }
        public string RefFormaPago { get; set; }
        public bool PagoPorTransferencia { get; set; }
        public decimal Deposito { get; set; }
        public decimal CantTransferencia { get; set; }
        public decimal CantDeposito { get; set; }
        public int FolioDeposito { get; set; }
        public bool ValidaPago { get; set; }
        public int FolioApp { get; set; }
        public short? MotivoRevId { get; set; }
        public bool? PendienteAutori { get; set; }
    }
}
