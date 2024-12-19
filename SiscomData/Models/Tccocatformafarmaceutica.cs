﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocatformafarmaceutica
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
    }
}