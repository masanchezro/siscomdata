
namespace SiscomData.DTOS
{
    public class RentasRecetasResult
    {
        public string Sucursal_Renta { get; set; }
        public string Cliente_Renta { get; set; }
        public string Codigo_Renta { get; set; }
        public string CodigoEnvases_Renta { get; set; }
        public string TipoServicio_Receta { get; set; }
        public string FolioFactura_Receta { get; set; }
        public string CoincideCodigo { get; set; }
        public string CodigoRenta_Producto { get; set; }
        public string Codigo_Producto { get; set; }
        public string EnvCont_Matched { get; set; }
    }

}