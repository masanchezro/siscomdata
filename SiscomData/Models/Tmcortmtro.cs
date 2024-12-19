using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcortmtro
    {
        public short Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public DateTime FechaRuteo { get; set; }
        public string TipoRuteo { get; set; }
        public string TipoCaptura { get; set; }
        public string Nombre { get; set; }
        public TimeSpan? InicioIntervaloHora { get; set; }
        public TimeSpan? FinIntervaloHora { get; set; }
        public int? Cantidad { get; set; }
        public int? Cantidad2 { get; set; }
        public int? DuracionDescarga { get; set; }
        public int? OrdenRuta { get; set; }
        public short? IdentificadorRuta { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime? FechaFolio { get; set; }
        public string Calle { get; set; }
        public string Numext { get; set; }
        public string Numint { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string FiltroRutas { get; set; }
        public string Movil { get; set; }
        public string TipoUnidad { get; set; }
        public bool? Procesar { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public int? IdDirEntrega { get; set; }
    }
}
