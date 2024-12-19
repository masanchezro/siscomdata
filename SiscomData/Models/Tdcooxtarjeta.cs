using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcooxtarjeta
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NumTarjeta { get; set; }
        public int Banco { get; set; }
        public string Vigencia { get; set; }
        public string Cvv2 { get; set; }
        public string TarjetaHabiente { get; set; }
        public string Telefono { get; set; }

        public virtual Tccoctbanco BancoNavigation { get; set; }
        public virtual Tmcooxcliente Tmcooxcliente { get; set; }
    }
}
