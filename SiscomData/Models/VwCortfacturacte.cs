using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCortfacturacte
    {
        public short? Ruta { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string HrLleg { get; set; }
        public string HrSal { get; set; }
        public string Kilomet { get; set; }
        public int? Cilin { get; set; }
        public int Regre { get; set; }
        public int Merc { get; set; }
        public DateTime? Fecharuteo { get; set; }
    }
}
