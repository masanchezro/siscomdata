using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoexpprofseries
    {
        public int Sucursal { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string NoSerie { get; set; }
        public string Modelo { get; set; }
        public string SubModelo { get; set; }
        public string Marca { get; set; }

        public virtual Tdcoexpprof Tdcoexpprof { get; set; }
    }
}
