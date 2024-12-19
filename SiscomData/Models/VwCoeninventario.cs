using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoeninventario
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public short? Patios { get; set; }
        public short Intocables { get; set; }
        public short? SubTtotal { get; set; }
        public int Fllenos { get; set; }
        public int Fvacios { get; set; }
        public int Fruta { get; set; }
        public int Fintocables { get; set; }
        public int FconteoFisico { get; set; }
        public int Fdiferencia { get; set; }
        public int? Amtto { get; set; }
        public int Aaumentos { get; set; }
        public int? Aadecuacion { get; set; }
        public int Sucursales { get; set; }
        public int Particulares { get; set; }
        public int Pendientes { get; set; }
        public int? Otros { get; set; }
        public int Total { get; set; }
        public int DifNeta { get; set; }
        public string Aclaraciones { get; set; }
        public bool? Validar { get; set; }
        public short NumFamilia { get; set; }
        public string Familia { get; set; }
    }
}
