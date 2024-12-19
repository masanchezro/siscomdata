using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoerrorfac
    {
        public int Id { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string TipoDocumento { get; set; }
        public int? Folio { get; set; }
        public string Rfc { get; set; }
        public string NombreCompleto { get; set; }
        public string CodigoPostal { get; set; }
        public string TipoReg { get; set; }
        public string CodigoError { get; set; }
        public string MensajeError { get; set; }
        public string Estatus { get; set; }
        public DateTime FechaError { get; set; }

        public virtual Tccoerror CodigoErrorNavigation { get; set; }
        public virtual Tccofacatregfi TipoRegNavigation { get; set; }
        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
