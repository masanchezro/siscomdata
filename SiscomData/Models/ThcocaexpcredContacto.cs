using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ThcocaexpcredContacto
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreContacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Extension { get; set; }
        public string Departamento { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int Id { get; set; }

        public virtual ThcocaexpcredGenerale ThcocaexpcredGenerale { get; set; }
    }
}
