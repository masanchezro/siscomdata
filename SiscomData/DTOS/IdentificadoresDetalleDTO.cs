using System; 

namespace SiscomData.DTOS
{
    public class IdentificadoresDetalleDTO
    {
        public int rowID { get; set; }
        public string servicio_Id { get; set; }
        public string prioridad { get; set; }
        public int sucursal { get; set; }
        public int cliente { get; set; }
        public int codigo { get; set; }
        public string serie { get; set; }
        public DateTime fechaRecepcion { get; set; }
        public double geoLon { get; set; }
        public double geoLat { get; set; }
        public int chofer { get; set; }
        public decimal? montoEfectivo { get; set; }
        public decimal? montoTarjeta { get; set; }
        public string confirmacionTarjeta { get; set; }
        public decimal? montoTransferencia { get; set; }
        public string confirmacionTransferencia { get; set; }
        public string transferencia { get; set; }
        public string codigoTransferencia { get; set; }
        public string comentariosMotivoSV { get; set; }
        public int? estatusID { get; set; }
        public int sector { get; set; }
        public string modelo { get; set; }
        public string modeloSISCOM { get; set; }
    }
}
