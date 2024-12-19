using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxcliente
    {
        public Tmcooxcliente()
        {
            Tdcooxcapreceta = new HashSet<Tdcooxcapreceta>();
            Tdcooxreceta = new HashSet<Tdcooxreceta>();
            Tdcooxrentasctes = new HashSet<Tdcooxrentascte>();
            Tdcooxtarjeta = new HashSet<Tdcooxtarjeta>();
            Tmcooxservicios = new HashSet<Tmcooxservicio>();
        }

        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Afiliacion { get; set; }
        public string Clave { get; set; }
        public short Delegacion { get; set; }
        public short Clinica { get; set; }
        public string FamResponsable { get; set; }
        public string Sector { get; set; }
        public string Solicitante { get; set; }
        public int FormaPago { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int FolioBaja { get; set; }
        public string UsuarioBaja { get; set; }
        public int CteFirma { get; set; }
        public bool Factura { get; set; }
        public bool FacturaGlobal { get; set; }
        public string Matricula { get; set; }
        public bool Empleado { get; set; }
        public string ObservacionesCte { get; set; }
        public string TipoParticular { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string AgrMedico { get; set; }
        public bool? Electronico { get; set; }
        public string NoPoliza { get; set; }
        public DateTime? VigenciaPoliza { get; set; }
        public string CobroConsumible { get; set; }
        public int? NomTtrasociado { get; set; }
        public int? MotivoCancelacion { get; set; }
        public int? IdMedico { get; set; }
        public DateTime? FasigMedicoRef { get; set; }
        public bool? CobroAticipado { get; set; }
        public bool? ActualizadoApp { get; set; }
        public string ExcentoRecarga { get; set; }
        public DateTime? FechaUtlSincronizacion { get; set; }

        public virtual Tmcoctgral Tmcoctgral { get; set; }
        public virtual ICollection<Tdcooxcapreceta> Tdcooxcapreceta { get; set; }
        public virtual ICollection<Tdcooxreceta> Tdcooxreceta { get; set; }
        public virtual ICollection<Tdcooxrentascte> Tdcooxrentasctes { get; set; }
        public virtual ICollection<Tdcooxtarjeta> Tdcooxtarjeta { get; set; }
        public virtual ICollection<Tmcooxservicio> Tmcooxservicios { get; set; }
    }
}
