using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcooxlistadoreceta
    {
        public int IdCapRecetas { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Curp { get; set; }
        public string NombreCte { get; set; }
        public string Afiliacion { get; set; }
        public string Matricula { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? FolioBaja { get; set; }
        public string FolioReceta { get; set; }
        public int? FolioFactura { get; set; }
        public string TipoMovimiento { get; set; }
        public string Direccion { get; set; }
        public int? DiaIni { get; set; }
        public int? DiaFin { get; set; }
        public int? Dias { get; set; }
        public decimal? Precio { get; set; }
        public int? Institucion { get; set; }
        public short? Delegacion { get; set; }
        public short? Unidad { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string TipoCaptura { get; set; }
        public string TipoCte { get; set; }
        public int? SubTipoCte { get; set; }
        public string TipoServicio { get; set; }
        public DateTime? DpfechaInicio { get; set; }
        public DateTime? DpfechaFin { get; set; }
        public string EstatusMov { get; set; }
        public string Estatus { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public DateTime? FechaAudit { get; set; }
        public short? SucDestino { get; set; }
        public int? CteFactura { get; set; }
        public bool? AplicaListado { get; set; }
    }
}
