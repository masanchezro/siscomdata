using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tpuesto
    {
        public int TpuId { get; set; }
        public string TpuDescorta { get; set; }
        public string TpuDescripcion { get; set; }
        public bool? TpuActivo { get; set; }
    }
}
