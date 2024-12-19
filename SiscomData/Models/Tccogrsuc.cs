using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrsuc
    {
        public Tccogrsuc()
        {
            Tccoinccpers = new HashSet<Tccoinccper>();
            Tcconoemps = new HashSet<Tcconoemp>();
            Tdcoendotideals = new HashSet<Tdcoendotideal>();
            Thcoinaybs = new HashSet<Thcoinayb>();
            Thcoinmov1s = new HashSet<Thcoinmov1>();
            Thcoinmovs = new HashSet<Thcoinmov>();
            Tmcoenpedidoses = new HashSet<Tmcoenpedidose>();
            Tmcoenpedidosns = new HashSet<Tmcoenpedidosn>();
            Tmcoenv01s = new HashSet<Tmcoenv01>();
            Tmcoinprod02s = new HashSet<Tmcoinprod02>();
            Tmcoinprodexps = new HashSet<Tmcoinprodexp>();
            Tmcooxejecutivos = new HashSet<Tmcooxejecutivo>();
        }

        public short Area { get; set; }
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public string TipoSucursal { get; set; }
        public string MarcaExcel { get; set; }
        public short? PoliticaVentas { get; set; }
        public int Ccplanta { get; set; }
        public int Ccagrupacion { get; set; }
        public string DiaPedido { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Ccelectrodos { get; set; }
        public double? Iva { get; set; }
        public string Prochemex { get; set; }
        public int DiaSurtimiento { get; set; }
        public string SerieFactura { get; set; }
        public short? Ruta { get; set; }
        public string Nacional { get; set; }
        public string MatrizMetro { get; set; }
        public short? Agrupadas { get; set; }
        public bool Impuestos { get; set; }
        public string NombrePta { get; set; }
        public short? Procesar { get; set; }
        public string Email { get; set; }
        public string BajaSucursal { get; set; }
        public DateTime FechaAlta { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string LocationNomina { get; set; }
        public string Marcacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string TipoTransmision { get; set; }
        public string CcSap { get; set; }
        public string Categoria { get; set; }
        public string CcSapAcetileno { get; set; }
        public string CcSapOxidom { get; set; }
        public string Fenuevos { get; set; }
        public bool SucFrontera { get; set; }
        public bool CentroMantto { get; set; }
        public bool PermisoE01 { get; set; }
        public bool SucSap { get; set; }
        public bool TransmiteComisiones { get; set; }
        public short? Ccnodo { get; set; }
        public string TipoEmpaque { get; set; }
        public bool? ControlIngresoCaja { get; set; }

        public virtual Tccogrpai PaisNavigation { get; set; }
        public virtual ICollection<Tccoinccper> Tccoinccpers { get; set; }
        public virtual ICollection<Tcconoemp> Tcconoemps { get; set; }
        public virtual ICollection<Tdcoendotideal> Tdcoendotideals { get; set; }
        public virtual ICollection<Thcoinayb> Thcoinaybs { get; set; }
        public virtual ICollection<Thcoinmov1> Thcoinmov1s { get; set; }
        public virtual ICollection<Thcoinmov> Thcoinmovs { get; set; }
        public virtual ICollection<Tmcoenpedidose> Tmcoenpedidoses { get; set; }
        public virtual ICollection<Tmcoenpedidosn> Tmcoenpedidosns { get; set; }
        public virtual ICollection<Tmcoenv01> Tmcoenv01s { get; set; }
        public virtual ICollection<Tmcoinprod02> Tmcoinprod02s { get; set; }
        public virtual ICollection<Tmcoinprodexp> Tmcoinprodexps { get; set; }
        public virtual ICollection<Tmcooxejecutivo> Tmcooxejecutivos { get; set; }
    }
}
