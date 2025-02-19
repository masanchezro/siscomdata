﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoctpreesp
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public decimal PrecioActual { get; set; }
        public decimal PrecioAnterior { get; set; }
        public string Moneda { get; set; }
        public bool Estatus { get; set; }
        public DateTime? Vigencia { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string TipoMovimiento { get; set; }
    }
}
