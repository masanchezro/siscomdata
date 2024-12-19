using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrterminale
    {
        public int IdTerminal { get; set; }
        public short? Sucursal { get; set; }
        public string ReferenciaBancaria { get; set; }
        public string Descripcion { get; set; }
        public int? IdBanco { get; set; }
        public string CuentaContable { get; set; }
        public string DescripcionBancoTerminal { get; set; }

        public virtual Tccoctbanco IdBancoNavigation { get; set; }
    }
}
