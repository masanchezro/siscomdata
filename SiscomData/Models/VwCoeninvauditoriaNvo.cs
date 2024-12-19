﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoeninvauditoriaNvo
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public DateTime Fecha { get; set; }
        public int? SdotacionTotal { get; set; }
        public int? FconteoFisico { get; set; }
        public int? FrepartoUrb { get; set; }
        public int? FrepartoForaneo { get; set; }
        public int? FtotalFisico { get; set; }
        public int? AmttoDebo { get; set; }
        public int? AmttoNoDebo { get; set; }
        public int? Aaumentos { get; set; }
        public int? Aadecuacion { get; set; }
        public int? AdependientesDebo { get; set; }
        public int? AnodoDebo { get; set; }
        public int? Aparticulares { get; set; }
        public int? Apendientes { get; set; }
        public int? AotrosDebo { get; set; }
        public int? AotrosNoDebo { get; set; }
        public int? Atotal { get; set; }
        public int? DiferenciaNeta { get; set; }
        public int? Familia { get; set; }
    }
}