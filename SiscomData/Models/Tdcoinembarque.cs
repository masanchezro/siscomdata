using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinembarque
    {
        public int FolioEmbarque { get; set; }
        public decimal? Cantidad { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Riesgo1 { get; set; }
        public decimal? Riesgo20 { get; set; }
        public decimal? Riesgo21 { get; set; }
        public decimal? PesoBruto { get; set; }
        public decimal? PesoNeto { get; set; }
        public decimal? Volumen { get; set; }
        public string Unidadpeso { get; set; }
        public string Bienestransp { get; set; }
        public string Dimensiones { get; set; }
        public string Materialpeligroso { get; set; }
        public string Embalaje { get; set; }
        public string Fraccionarancelaria { get; set; }
        public string Uuidcomercioext { get; set; }
        public string Numguiaiden { get; set; }
        public string Descguiaiden { get; set; }
        public string Numpedimento { get; set; }
        public string Fraccarancelaria { get; set; }
        public string Uuidexterior { get; set; }
        public string Lotemedicamento { get; set; }
        public bool? LlenoVacio { get; set; }
    }
}
