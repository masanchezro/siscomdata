﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoexpprof
    {
        public Tmcoexpprof()
        {
            Tdcoexpprofs = new HashSet<Tdcoexpprof>();
        }

        public int Sucursal { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public string ZonaCotizar { get; set; }
        public string TerminoVenta { get; set; }
        public int? OrdenTrabajo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Presentacion { get; set; }
        public string Notas { get; set; }
        public string Condiciones { get; set; }
        public string TiempoEntrega { get; set; }
        public string Vigencia { get; set; }
        public string FormaPago { get; set; }
        public string Empaque { get; set; }
        public string Embarque { get; set; }
        public string Despedida { get; set; }
        public string NombreFirma { get; set; }
        public string PuestoFirma { get; set; }
        public string Puerto { get; set; }
        public string Moneda { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Idioma { get; set; }

        public virtual ICollection<Tdcoexpprof> Tdcoexpprofs { get; set; }
    }
}
