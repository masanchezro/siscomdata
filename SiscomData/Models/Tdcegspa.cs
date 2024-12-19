using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcegspa
    {
        public long DetPacienteId { get; set; }
        public int PacienteId { get; set; }
        public int? EmpresaId { get; set; }
        public int? SucursalId { get; set; }
        public int? NoCliente { get; set; }
        public int? HospitalId { get; set; }
        public int? TipoInsumoId { get; set; }
        public string Calle { get; set; }
        public string NoExt { get; set; }
        public string NoInt { get; set; }
        public string Cpid { get; set; }
        public string Calle1 { get; set; }
        public string Calle2 { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string GeoLon { get; set; }
        public string GeoLat { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public int Orden { get; set; }
        public bool ConfActual { get; set; }
        public DateTime FechaAudit { get; set; }
        public string UsuarioAudit { get; set; }
    }
}
