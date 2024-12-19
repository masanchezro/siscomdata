using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxautorizafac
    {
        public int IdPermiso { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Folio { get; set; }
        public int FamServicioId { get; set; }
        public string Estatus { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public string UsuarioAplico { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public string UsuarioAutorizo { get; set; }
        public string RecepLog { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
