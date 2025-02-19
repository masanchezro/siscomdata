﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoencomcamp
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string TipoCam { get; set; }
        public short Anio { get; set; }
        public short Trimestre { get; set; }
        public int? Renta { get; set; }
        public int? Depositos { get; set; }
        public int? Facturados { get; set; }
        public int? TotServicios { get; set; }
        public int? ServiciosPag { get; set; }
        public int? DifServicios { get; set; }
        public int? Recogidos { get; set; }
        public int? RecogidosPag { get; set; }
        public int? DifRecogidos { get; set; }
        public int? Consumos { get; set; }
        public int? ConsumosPag { get; set; }
        public int? DifConsumos { get; set; }
        public decimal? Pago { get; set; }
        public int? Nomina { get; set; }
        public string NombreEmp { get; set; }
    }
}
