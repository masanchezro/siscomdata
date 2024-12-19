using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TccocadepartamentosEstatus
    {
        public string Id { get; set; }
        public string IdDepartamento { get; set; }
        public string NombreStatus { get; set; }

        public virtual Tccocadepartamento IdDepartamentoNavigation { get; set; }
    }
}
