using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcofaarchivosrem
    {
        public int Sucursal { get; set; }
        public int Remision { get; set; }
        public int Cliente { get; set; }
        public string Frente { get; set; }
        public int NumArchivo { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaArchivo { get; set; }
        public string ArchivoZip { get; set; }
        public bool Borrado { get; set; }
        public DateTime FechaRemision { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBorrado { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
