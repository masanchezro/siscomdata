using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinprov
    {
        public int Nproveedor { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Calle1 { get; set; }
        public string Calle2 { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string MunDel { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public int? CodPostal { get; set; }
        public string Pais { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Rfc { get; set; }
        public string TipoProv { get; set; }
        public string Moneda { get; set; }
        public bool? Bloqueado { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
