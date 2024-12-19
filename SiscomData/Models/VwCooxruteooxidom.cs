using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxruteooxidom
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Direccion { get; set; }
        public string Codpos { get; set; }
        public short Delegacion { get; set; }
        public short Clinica { get; set; }
        public int Pedido { get; set; }
        public string Servicio { get; set; }
        public string FormaPago { get; set; }
        public string Telefono1 { get; set; }
        public int Recetas { get; set; }
        public DateTime? FechaRuteo { get; set; }
        public string Usuario { get; set; }
        public int? Ruta { get; set; }
        public int? Expr1 { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Contrato { get; set; }
        public int Propiedad { get; set; }
        public decimal? ImporteConsumo { get; set; }
        public decimal? ImporteRenta { get; set; }
        public decimal? ImporteRecetas { get; set; }
        public string TipoCliente { get; set; }
        public bool Ruteado { get; set; }
        public string PrioridadServicio { get; set; }
        public int TipoServicio { get; set; }
        public bool Cancelado { get; set; }
        public string Calle1 { get; set; }
        public string Calle2 { get; set; }
        public string Observaciones { get; set; }
        public string CodBar { get; set; }
        public int? Toursolver1 { get; set; }
        public decimal? Importeiva { get; set; }
    }
}
