using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoctbanco
    {
        public Tccoctbanco()
        {
            Tccogrterminales = new HashSet<Tccogrterminale>();
            Tdcoenvmovs = new HashSet<Tdcoenvmov>();
            Tdcooxtarjeta = new HashSet<Tdcooxtarjeta>();
            Tmcocamovs = new HashSet<Tmcocamov>();
            Tmcoctrefbancos = new HashSet<Tmcoctrefbanco>();
        }

        public int Banco { get; set; }
        public string NombreBanco { get; set; }
        public int? SucBanco { get; set; }
        public string Cuenta { get; set; }
        public int? Convenio { get; set; }
        public string Clabe { get; set; }
        public string Descripcion { get; set; }
        public string Moneda { get; set; }
        public string CuentaContable { get; set; }
        public int? IdPoliza { get; set; }
        public bool? Activo { get; set; }
        public string Tipo { get; set; }
        public string Promociones { get; set; }
        public string RfcBanco { get; set; }
        public string NombreBancoComplemento { get; set; }
        public string CuentaBancoComplemento { get; set; }

        public virtual ICollection<Tccogrterminale> Tccogrterminales { get; set; }
        public virtual ICollection<Tdcoenvmov> Tdcoenvmovs { get; set; }
        public virtual ICollection<Tdcooxtarjeta> Tdcooxtarjeta { get; set; }
        public virtual ICollection<Tmcocamov> Tmcocamovs { get; set; }
        public virtual ICollection<Tmcoctrefbanco> Tmcoctrefbancos { get; set; }
    }
}
