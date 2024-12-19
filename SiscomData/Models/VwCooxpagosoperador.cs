using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxpagosoperador
    {
        public short Sucursal { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRuteo { get; set; }
        public short Ruta { get; set; }
        public short Turno { get; set; }
        public short Unidad { get; set; }
        public int? Operardor { get; set; }
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public string PrioridadServicio { get; set; }
        public string EstatusServicio { get; set; }
        public string EstatusDes { get; set; }
        public string Motivo { get; set; }
        public decimal? Importe { get; set; }
        public decimal Efectivo { get; set; }
        public decimal Tarjeta { get; set; }
        public decimal Deposito { get; set; }
        public decimal? Trasferencia { get; set; }
        public decimal? Total { get; set; }
        public bool Validar { get; set; }
    }
}
