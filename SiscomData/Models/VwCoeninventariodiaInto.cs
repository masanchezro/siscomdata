using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoeninventariodiaInto
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public DateTime? Fecha { get; set; }
        public int Codigo { get; set; }
        public string TipoEnv { get; set; }
        public string SubTipoEnv { get; set; }
        public int SdotacionTotal { get; set; }
        public short? Sintocables { get; set; }
        public int FconteoFisico { get; set; }
        public int FrepartoUrb { get; set; }
        public int? FrepartoForaneo { get; set; }
        public int FtotalFisico { get; set; }
        public int Fdiferencia { get; set; }
        public int? AmttoDebo { get; set; }
        public int? AmttoNoDebo { get; set; }
        public int? Aaumentos { get; set; }
        public int? Aadecuacion { get; set; }
        public int? AdependientesDebo { get; set; }
        public int? AnodoDebo { get; set; }
        public int Aparticulares { get; set; }
        public int Pendientes { get; set; }
        public int AotrosDebo { get; set; }
        public int AotrosNoDebo { get; set; }
        public int Atotal { get; set; }
        public int DiferenciaNeta { get; set; }
        public string Aclaraciones { get; set; }
        public short NumFamilia { get; set; }
        public bool? Validar { get; set; }
        public bool? Transmite { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
