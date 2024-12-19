using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tcwictefil01
    {
        public int Grupo { get; set; }
        public string NombreGpo { get; set; }
        public short? Formato { get; set; }
        public bool? EditaCte { get; set; }
        public short? FormatoSec { get; set; }
        public short? SucDecidePrecio { get; set; }
        public int? NumEmpDecidePrecio { get; set; }
        public int? GrupoConcentrador { get; set; }
        public short? OrdenListadoCartera { get; set; }
        public short? Institucion { get; set; }
        public string GestionPorResp { get; set; }
        public string FormatoCartera { get; set; }
        public string Division { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
