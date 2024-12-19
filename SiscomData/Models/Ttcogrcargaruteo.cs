using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcogrcargaruteo
    {
        public short? Numero { get; set; }
        public short? EntregaMovil { get; set; }
        public string Zona { get; set; }
        public string RutaEntrega { get; set; }
        public string Entrega { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Direccion { get; set; }
        public string Tipo1 { get; set; }
        public string Cantidad1 { get; set; }
        public string Tipo2 { get; set; }
        public string Cantidad2 { get; set; }
        public DateTime? Fecha { get; set; }
        public string GeoIni { get; set; }
        public string TipoMovilSol { get; set; }
        public string Libre1 { get; set; }
        public string Libre2 { get; set; }
        public string Libre3 { get; set; }
        public string Libre4 { get; set; }
        public string Libre5 { get; set; }
        public string Id { get; set; }
    }
}
