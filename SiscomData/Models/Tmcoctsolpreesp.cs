using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctsolpreesp
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int TipoProducto { get; set; }
        public decimal VolumenDeCompra { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal PrecioEspecialActual { get; set; }
        public DateTime? FechaUltimoCambio { get; set; }
        public decimal PrecioSolicitado { get; set; }
        public decimal PrecioAutorizado { get; set; }
        public string Moneda { get; set; }
        public string Motivo { get; set; }
        public int NumEmpleado { get; set; }
        public bool CliesteEspecial { get; set; }
        public bool ClienteEspecialMercancias { get; set; }
        public int Folio { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public string Estatus { get; set; }
        public DateTime? Vigencia { get; set; }
        public DateTime? FechaRespuestas { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
        public bool Demora { get; set; }
        public bool Mantenimiento { get; set; }
        public bool See { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
        public virtual Tcconoemp Tcconoemp { get; set; }
        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
