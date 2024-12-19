using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoencontrolenv
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Patios { get; set; }
        public int? Clientes { get; set; }
        public int? Oxidom { get; set; }
        public int? Sucursales { get; set; }
        public int? Propiedad { get; set; }
        public int? Intocables { get; set; }
        public int? TotalEnvases { get; set; }
        public string TipoProd { get; set; }
        public short NumFamilia { get; set; }
        public string Familia { get; set; }
        public string TipoEnvase { get; set; }
        public string Subtipo { get; set; }
        public string Valvula { get; set; }
        public string ImagenEnv { get; set; }
    }
}
