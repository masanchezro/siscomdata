using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Bdakm01SatAddendum
    {
        public short Suc { get; set; }
        public int Cliente { get; set; }
        public string Email { get; set; }
        public string Addenda { get; set; }
        public decimal? NoProveedor { get; set; }
        public string Sociedad { get; set; }
        public decimal? Rireceptor { get; set; }
        public decimal? NoProvRecep { get; set; }
        public decimal? Riemisor { get; set; }
        public string ParteSeriePdas { get; set; }
        public string Lista1 { get; set; }
        public string Lista2 { get; set; }
        public string Lista3 { get; set; }
        public string Lista4 { get; set; }
        public string Lista5 { get; set; }
    }
}
