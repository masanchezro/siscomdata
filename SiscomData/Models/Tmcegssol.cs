using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcegssol
    {
        public int Folio { get; set; }
        public DateTime FechaSol { get; set; }
        public int PacienteId { get; set; }
        public int TipoServicio { get; set; }
        public string Diagnostico { get; set; }
        public int? Estatus { get; set; }
        public int? EmpresaId { get; set; }
        public int? Sucursal { get; set; }
    }
}
