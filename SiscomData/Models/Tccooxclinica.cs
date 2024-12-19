﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxclinica
    {
        public short Sucursal { get; set; }
        public short Delegacion { get; set; }
        public short Unidad { get; set; }
        public int IdClienteOx { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int CteFactura { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Repetido { get; set; }

        public virtual Tccooxcliente IdClienteOxNavigation { get; set; }
    }
}
