using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcotrpaciente
    {
        public int Id { get; set; }
        public int Idws { get; set; }
        public string IdTransaccion { get; set; }
        public int Delegacion { get; set; }
        public string Nss { get; set; }
        public string NoAfiliacion { get; set; }
        public string AgrMedico { get; set; }
        public int Unidad { get; set; }
        public string Consultorio { get; set; }
        public string Turno { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Ocupacion { get; set; }
        public string Estatura { get; set; }
        public string Peso { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string NumeroInt { get; set; }
        public string Cruce1 { get; set; }
        public string Cruce2 { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string CodPostal { get; set; }
        public string RefDomicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Equipo { get; set; }
        public string NoPaciente { get; set; }
        public string Observaciones { get; set; }
        public int? ClienteAtiende { get; set; }
        public int? ClienteFactura { get; set; }
        public DateTime? FechaAudit { get; set; }
        public bool? Enviado { get; set; }
        public DateTime? FechaCargaImss { get; set; }
        public DateTime? FechaInfra { get; set; }
        public DateTime? FechaPedido { get; set; }
        public string Origen { get; set; }
        public string Usuario { get; set; }
    }
}
