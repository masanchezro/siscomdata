using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmReceta
    {
        public string Id { get; set; }
        public string NoAfiliacion { get; set; }
        public string AgrMedico { get; set; }
        public string Nss { get; set; }
        public string Delegacion { get; set; }
        public string FechaInicio { get; set; }
    }
}
