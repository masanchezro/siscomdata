using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxcontrato
    {
        public int IdContrato { get; set; }
        public int Cliente { get; set; }
        public decimal Deposito { get; set; }
        public decimal MontoRenta { get; set; }
        public string Tecnico { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Calle { get; set; }
        public string Numext { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Codpos { get; set; }
        public string Telefono1 { get; set; }
        public string Afiliacion { get; set; }
        public string FamResponsable { get; set; }
        public int? Banco { get; set; }
        public string NumTarjeta { get; set; }
        public string Vigencia { get; set; }
        public string TarjetaHabiente { get; set; }
        public string Institucion { get; set; }
    }
}
