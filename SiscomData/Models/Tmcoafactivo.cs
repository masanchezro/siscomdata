using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoafactivo
    {
        public int IdActivo { get; set; }
        public short Sucursal { get; set; }
        public int CentroCostos { get; set; }
        public string Clave { get; set; }
        public string Serie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Motor { get; set; }
        public string Rfa { get; set; }
        public string Placas { get; set; }
        public string NumEco { get; set; }
        public string NumActivoFijo { get; set; }
        public string Descripcion { get; set; }
        public int? Cantidad { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Tccoafdetalle ClaveNavigation { get; set; }
    }
}
