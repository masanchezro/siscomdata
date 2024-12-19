using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoidsuc
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public string DescripcionSucursal { get; set; }
        public string IdentificadorPermiso { get; set; }
        public long FolioFichas { get; set; }
        public bool? BanderaInforme { get; set; }
        public bool? Ingresos { get; set; }
        public int? FolRecibosIngreosCaja { get; set; }
        public string MovimientosIngresos { get; set; }
        public bool? Cartera { get; set; }
        public string CondicionA01 { get; set; }
        public bool? Gastos { get; set; }
        public bool? GarantiasDevoluciones { get; set; }
        public bool? Transferencias { get; set; }
        public bool? Ventas { get; set; }
        public bool? PermisoDespuesInforme { get; set; }
    }
}
