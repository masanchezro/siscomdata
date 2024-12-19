using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinconrutasdi
    {
        public short? Ruta { get; set; }
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public long Folio { get; set; }
        public string Movimineto { get; set; }
        public long PedidoRemision { get; set; }
        public string TipoSuc { get; set; }
    }
}
