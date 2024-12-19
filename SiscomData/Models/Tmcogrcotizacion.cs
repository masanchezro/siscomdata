using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcogrcotizacion
    {
        public Tmcogrcotizacion()
        {
            Tdcogrcotizaciones = new HashSet<Tdcogrcotizacione>();
            Tdcogrleyendacotizacions = new HashSet<Tdcogrleyendacotizacion>();
        }

        public string NoCotizacion { get; set; }
        public int? NoEjecutivo { get; set; }
        public int? NoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Atencion { get; set; }
        public string Calle { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Calle1 { get; set; }
        public string Calle2 { get; set; }
        public string Ciudad { get; set; }
        public string Cp { get; set; }
        public string Estado { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalDevolucion { get; set; }
        public decimal? TotalMantenimiento { get; set; }
        public decimal? TotalLentaRotacion { get; set; }
        public decimal? TotalSee { get; set; }
        public string Observaciones { get; set; }
        public string Contrasenia { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual ICollection<Tdcogrcotizacione> Tdcogrcotizaciones { get; set; }
        public virtual ICollection<Tdcogrleyendacotizacion> Tdcogrleyendacotizacions { get; set; }
    }
}
