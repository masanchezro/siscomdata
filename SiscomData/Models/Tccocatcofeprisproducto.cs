using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocatcofeprisproducto
    {
        public int Id { get; set; }
        public int? CodigoProducto { get; set; }
        public string SectorCofepris { get; set; }
        public string DenominacionGenericaProd { get; set; }
        public string DenominacionDistintivaProd { get; set; }
        public string Fabricante { get; set; }
        public DateTime? FechaCaducidad { get; set; }
        public string LoteMedicamento { get; set; }
        public string FormaFarmaceutica { get; set; }
        public string CondicionesEspTransp { get; set; }
        public string RegistroSanitarioFolioAutorizacion { get; set; }
        public string NombreIngredienteActivo { get; set; }
        public string NomQuimico { get; set; }
        public string PermisoImportacion { get; set; }
        public string FolioImpoVucem { get; set; }
        public string NumCas { get; set; }
        public string RazonSocialEmpImp { get; set; }
        public string NumRegSanPlagCofepris { get; set; }
        public string DatosFabricante { get; set; }
        public string DatosFormulador { get; set; }
        public string DatosMaquilador { get; set; }
        public string UsoAutorizado { get; set; }
    }
}
