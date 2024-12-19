using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoeninventario
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public int? Spatios { get; set; }
        public int? Sintocables { get; set; }
        public int? SdotacionTot { get; set; }
        public int? Fllenos { get; set; }
        public int? Fvacios { get; set; }
        public int? Fruta { get; set; }
        public int? Fintocables { get; set; }
        public int? FconteoFisico { get; set; }
        public int? Fdiferencia { get; set; }
        public int? Amtto { get; set; }
        public int? Aaumentos { get; set; }
        public int? Aadecuacion { get; set; }
        public int? Asucursales { get; set; }
        public int? Aparticulares { get; set; }
        public int? Apendientes { get; set; }
        public int? Aotros { get; set; }
        public int? Atotal { get; set; }
        public int? DiferenciaNeta { get; set; }
        public bool? Validar { get; set; }
        public string Aclaraciones { get; set; }
        public int? Familia { get; set; }
        public bool? Transmite { get; set; }

        public virtual Tmcoenv01 Tmcoenv01 { get; set; }
    }
}
