using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxpoblacionCpapbpap
    {
        public string Cc { get; set; }
        public short Suc { get; set; }
        public int Cliente { get; set; }
        public string Curp { get; set; }
        public string NombreCte { get; set; }
        public string Afiliacion { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string Telefono1 { get; set; }
        public int? Delegacion { get; set; }
        public int? Clinica { get; set; }
        public string NomClinica { get; set; }
        public string Equipo { get; set; }
        public short? Cantidad { get; set; }
        public string TipoConsulta { get; set; }
        public string FamiliaServicio { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string Observaciones { get; set; }
        public int CteFirma { get; set; }
        public int? IdInstitucion { get; set; }
        public string NomInstitucion { get; set; }
        public string Municipio { get; set; }
        public string CodigoPostal { get; set; }
        public string Ejecutivo { get; set; }
        public int? SubTipoCte { get; set; }
        public int Codigo { get; set; }
        public int? IdFamiliaServicio { get; set; }
        public short? EnvCont { get; set; }
        public bool Cancelado { get; set; }
    }
}
