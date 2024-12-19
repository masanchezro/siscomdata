using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxcancondeposito
    {
        public short Sucursal { get; set; }
        public string Inst { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public short Delegacion { get; set; }
        public short Clinica { get; set; }
        public string Cancelado { get; set; }
        public string Fechabaja { get; set; }
        public int FolioBaja { get; set; }
        public string Usuario { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short? EnvCont { get; set; }
        public decimal? Deposito { get; set; }
        public int? Antiguedad { get; set; }
    }
}
