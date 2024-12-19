using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinprodexp
    {
        public short Almacen { get; set; }
        public int Codigo { get; set; }
        public int SubCodigo { get; set; }
        public int Proveedor { get; set; }
        public string Um { get; set; }
        public string Umi { get; set; }
        public decimal? CostoCompra { get; set; }
        public string DescripcionEsp { get; set; }
        public string DescripcionEng { get; set; }
        public int? MultiploEmpaque { get; set; }
        public string FraccionArancelaria { get; set; }
        public decimal? MinimaCompra { get; set; }
        public decimal? PvSudAmerica { get; set; }
        public decimal? PvCentroAmerica { get; set; }
        public decimal? PvCuba { get; set; }
        public decimal? PvUsa { get; set; }
        public decimal? PvOtros { get; set; }
        public float? PFob { get; set; }
        public float? PCfr { get; set; }
        public float? PCif { get; set; }
        public float? POtros { get; set; }
        public string UsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public string UsuarioAudit { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Origen { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SubModelo { get; set; }
        public string Umtigie { get; set; }
        public decimal? CantidadTigie { get; set; }
        public decimal? PrecioTigie { get; set; }
        public string Moneda { get; set; }

        public virtual Tccogrsuc AlmacenNavigation { get; set; }
        public virtual Tmcoinprod01 SubCodigoNavigation { get; set; }
    }
}
