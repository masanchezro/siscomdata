using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinhojaembarque
    {
        public int FolioEmbarque { get; set; }
        public DateTime? Fecha { get; set; }
        public short? Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public string DireccionSuc { get; set; }
        public int? SucDestino { get; set; }
        public string NombreSucDes { get; set; }
        public string DireccionSucDes { get; set; }
        public string MunicipioDes { get; set; }
        public string EstadoDes { get; set; }
        public int? Responsable { get; set; }
        public string NombreRes { get; set; }
        public string PuestoRes { get; set; }
        public int? Operador { get; set; }
        public string NomOperador { get; set; }
        public string PuestoOperador { get; set; }
        public string NoEconomico1 { get; set; }
        public string DesU1 { get; set; }
        public string MatriculaU1 { get; set; }
        public string Dimensiones1 { get; set; }
        public decimal? TaraU1 { get; set; }
        public decimal? PesoU1 { get; set; }
        public string NoEconomico2 { get; set; }
        public string DesU2 { get; set; }
        public string MatriculaU2 { get; set; }
        public string Dimensiones2 { get; set; }
        public int TaraU2 { get; set; }
        public decimal PesoU2 { get; set; }
        public string NoEconomico3 { get; set; }
        public string DesU3 { get; set; }
        public string MatriculaU3 { get; set; }
        public string Dimensiones3 { get; set; }
        public int TaraU3 { get; set; }
        public decimal PesoU3 { get; set; }
        public string NoEconomico4 { get; set; }
        public string DesU4 { get; set; }
        public string MatriculaU4 { get; set; }
        public string Dimensiones4 { get; set; }
        public int TaraU4 { get; set; }
        public decimal PesoU4 { get; set; }
        public string Sello { get; set; }
        public string Observaciones { get; set; }
        public short? Ruta { get; set; }
        public byte[] Imagen1 { get; set; }
        public byte[] Imagen2 { get; set; }
        public byte[] Imagen3 { get; set; }
        public byte[] Imagen4 { get; set; }
        public string Uusario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
