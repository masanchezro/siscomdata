using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcorttemp
    {
        public int Numero { get; set; }
        public int? EntregasMóvil { get; set; }
        public string Móvil { get; set; }
        public string Zona { get; set; }
        public int? RutaEntrega { get; set; }
        public string Entrega { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lon { get; set; }
        public string Dirección { get; set; }
        public string Tipo1 { get; set; }
        public decimal? Cantidad1 { get; set; }
        public string Tipo2 { get; set; }
        public decimal? Cantidad2 { get; set; }
        public string Fecha { get; set; }
        public string GeoInicio { get; set; }
        public string TipoMóvilSol { get; set; }
        public string Libre1 { get; set; }
        public string Libre2 { get; set; }
        public string Libre3 { get; set; }
        public string Libre4 { get; set; }
        public string Libre5 { get; set; }
        public string IdTipo { get; set; }
    }
}
