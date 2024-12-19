using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenconsultum
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public short Ejecutivo { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string TipoCte { get; set; }
        public string SubTipoCte { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string TipoProd { get; set; }
        public string TipoEnvase { get; set; }
        public short? Contrato { get; set; }
        public short? Propiedad { get; set; }
        public short? Provisional { get; set; }
        public decimal? Deposito { get; set; }
        public DateTime? FechaAltaEnvases { get; set; }
        public DateTime? FechaUltConsumo { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int ConsumoMesAct { get; set; }
        public int ConsumoAcum { get; set; }
        public string Usuario { get; set; }
        public int IdVarianteSubTc { get; set; }
    }
}
