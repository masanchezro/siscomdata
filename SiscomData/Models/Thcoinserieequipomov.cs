using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoinserieequipomov
    {
        public long Id { get; set; }
        public int? Sucursal { get; set; }
        public int? Codigo { get; set; }
        public string NoSerie { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime? FechaMov { get; set; }
        public int? Origen { get; set; }
        public string TipoOrigen { get; set; }
        public int? Destino { get; set; }
        public string TipoDestino { get; set; }
        public string Usuario { get; set; }
        public int? Lote { get; set; }
    }
}
