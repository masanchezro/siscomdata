using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoidsapfile
    {
        public DateTime Fechaarchivo { get; set; }
        public string Nombrearchivo { get; set; }
        public bool Status { get; set; }
        public string Tipo { get; set; }
    }
}
