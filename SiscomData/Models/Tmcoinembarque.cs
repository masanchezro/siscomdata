using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinembarque
    {
        public int FolioEmbarque { get; set; }
        public short? Sucursal { get; set; }
        public int? SucDestino { get; set; }
        public int? Responsable { get; set; }
        public int? Operador { get; set; }
        public DateTime? Fecha { get; set; }
        public string NoEconomico1 { get; set; }
        public string NoEconomico2 { get; set; }
        public string NoEconomico3 { get; set; }
        public string NoEconomico4 { get; set; }
        public string Sello { get; set; }
        public string Observaciones { get; set; }
        public short? Ruta { get; set; }
        public byte[] Imagen1 { get; set; }
        public byte[] Imagen2 { get; set; }
        public byte[] Imagen3 { get; set; }
        public byte[] Imagen4 { get; set; }
        public string Uusario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Transpinternac { get; set; }
        public string Entradasalidamerc { get; set; }
        public string Viaentradasalida { get; set; }
        public string Tipoestacion { get; set; }
        public string Distanciarecorrida { get; set; }
        public string Permsct { get; set; }
        public string Numpermisosct { get; set; }
        public string Nombreaseg { get; set; }
        public string Numpolizaseguro { get; set; }
        public string Numguiaiden { get; set; }
        public string Descguiaiden { get; set; }
        public string Numpedimento { get; set; }
        public string Idccp { get; set; }
        public bool Esrecolecciondevolucion { get; set; }
        public string TieneXml { get; set; }
        public string Uuid { get; set; }
        public string CodigoP { get; set; }
        public string Calle { get; set; }
        public string NumInt { get; set; }
        public string NumExt { get; set; }
        public string CodigoCol { get; set; }
    }
}
