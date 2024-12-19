using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxclientessuspendido
    {
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Direccion { get; set; }
        public string FormaCobro { get; set; }
        public string FormaPago { get; set; }
        public string NombreInst { get; set; }
        public string NombreClini { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public DateTime? Alta { get; set; }
        public DateTime? FechaSuspencion { get; set; }
        public int? DiasSuspendido { get; set; }
        public string MotivoSuspencion { get; set; }
        public int Codigo { get; set; }
        public string Equipo { get; set; }
        public short? Cantidad { get; set; }
    }
}
