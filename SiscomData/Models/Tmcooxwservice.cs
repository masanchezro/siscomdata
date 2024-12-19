using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxwservice
    {
        public Tmcooxwservice()
        {
            Tmcowtransidentificas = new HashSet<Tmcowtransidentifica>();
        }

        public int Id { get; set; }
        public string Servicio { get; set; }
        public string Descripcion { get; set; }
        public string NombreWs { get; set; }
        public string Servidor { get; set; }
        public string KeyId { get; set; }
        public string EstatusSev { get; set; }
        public DateTime? FultSync { get; set; }
        public string UsuarioFirmante { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual ICollection<Tmcowtransidentifica> Tmcowtransidentificas { get; set; }
    }
}
