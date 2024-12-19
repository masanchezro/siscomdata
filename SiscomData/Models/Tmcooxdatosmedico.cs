using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxdatosmedico
    {
        public int IdMedico { get; set; }
        public string EjecutivoCuenta { get; set; }
        public string Nombre { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Especialidad { get; set; }
        public string Correo { get; set; }
        public string CedulaProfesional { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Estatus { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Calle { get; set; }
        public string NumInt { get; set; }
        public string NumExt { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int? Cp { get; set; }
        public short? Sucursal { get; set; }
    }
}
