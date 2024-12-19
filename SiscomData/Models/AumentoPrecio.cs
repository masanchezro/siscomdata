using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class AumentoPrecio
    {
        public string CveProducto { get; set; }
        public string Descripcion { get; set; }
        public int CveCarga { get; set; }
        public int Suc { get; set; }
        public int Linea { get; set; }
        public decimal PorcAum { get; set; }
        public DateTime FechaIncremento { get; set; }
        public string Clave { get; set; }
        public decimal Pcio1 { get; set; }
        public decimal Pcio2 { get; set; }
        public decimal Pcio3 { get; set; }
        public string Status { get; set; }
        public int Codigo { get; set; }
        public string Status2 { get; set; }
    }
}
