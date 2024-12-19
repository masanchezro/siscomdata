using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcooxcapreceta
    {
        public Tdcooxcapreceta()
        {
            Tdcooxfolreceta = new HashSet<Tdcooxfolreceta>();
        }

        public int IdCapRecetas { get; set; }
        public short Sucursal { get; set; }
        public int Delegacion { get; set; }
        public int Clinica { get; set; }
        public int Sector { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int Cliente { get; set; }
        public int DiaIni { get; set; }
        public int DiaFin { get; set; }
        public int Dias { get; set; }
        public string TipoCaptura { get; set; }
        public string ProcesoCaptura { get; set; }
        public bool Cancelada { get; set; }
        public string MotivoCancelacion { get; set; }
        public string TipoServicio { get; set; }
        public bool EsReceta { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcooxcliente Tmcooxcliente { get; set; }
        public virtual ICollection<Tdcooxfolreceta> Tdcooxfolreceta { get; set; }
    }
}
