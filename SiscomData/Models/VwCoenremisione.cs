using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenremisione
    {
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public string DireccionSuc { get; set; }
        public string EntidadFederativa { get; set; }
        public int SucDestino { get; set; }
        public string NombreSucDestino { get; set; }
        public string DireccionSucDestino { get; set; }
        public int Remision { get; set; }
        public string Tipo { get; set; }
        public string TipoRemision { get; set; }
        public int FolioCabecera { get; set; }
        public int SucOrigen { get; set; }
        public DateTime FechaRemision { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? CantidadEnviar { get; set; }
        public decimal? Capacidad { get; set; }
        public string Valvula { get; set; }
        public bool LlenoVacio { get; set; }
        public bool Particular { get; set; }
        public string Serie { get; set; }
        public bool InformaEnsayo { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public short NumFamilia { get; set; }
        public string Familia { get; set; }
        public string NombreCliente { get; set; }
        public string TipoOrigen { get; set; }
    }
}
