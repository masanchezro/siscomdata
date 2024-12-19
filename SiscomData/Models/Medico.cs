using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Medico
    {
        public int MedicoId { get; set; }
        public string Nombre { get; set; }
        public short? SucursalId { get; set; }
    }
}
