using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Estudio
    {
        public int EstudioId { get; set; }
        public int TipoEstudioId { get; set; }
        public string Descripcion { get; set; }
        public short? SucursalId { get; set; }
    }
}
