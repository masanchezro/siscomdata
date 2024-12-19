using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinprod01
    {
        public Tmcoinprod01()
        {
            Tccoctporcodpreesps = new HashSet<Tccoctporcodpreesp>();
            Tccofapromomayoreos = new HashSet<Tccofapromomayoreo>();
            Tccoinproddescuentos = new HashSet<Tccoinproddescuento>();
            Tdcoendotideals = new HashSet<Tdcoendotideal>();
            Tdcoininventariomers = new HashSet<Tdcoininventariomer>();
            Tdcoinmovscodnogens = new HashSet<Tdcoinmovscodnogen>();
            Tdcoinmovscods = new HashSet<Tdcoinmovscod>();
            Tdcoinprodbars = new HashSet<Tdcoinprodbar>();
            Tdconocomgs = new HashSet<Tdconocomg>();
            Tdcooxequiposyes = new HashSet<Tdcooxequiposye>();
            Thcoinaybs = new HashSet<Thcoinayb>();
            Thcoinmovs = new HashSet<Thcoinmov>();
            Tmcoctpreesps = new HashSet<Tmcoctpreesp>();
            Tmcoctremisiones = new HashSet<Tmcoctremisione>();
            Tmcoctsolpreesps = new HashSet<Tmcoctsolpreesp>();
            Tmcoeninventarios = new HashSet<Tmcoeninventario>();
            Tmcoenv01s = new HashSet<Tmcoenv01>();
            TmcoenvcampLms = new HashSet<TmcoenvcampLm>();
            TmcoenvcampNcs = new HashSet<TmcoenvcampNc>();
            Tmcoenvremisiones = new HashSet<Tmcoenvremisione>();
            Tmcofacodprodctes = new HashSet<Tmcofacodprodcte>();
            Tmcoinprod02s = new HashSet<Tmcoinprod02>();
            Tmcoinprodexps = new HashSet<Tmcoinprodexp>();
            Tmcoinproduccions = new HashSet<Tmcoinproduccion>();
            Ttcoinpedgas = new HashSet<Ttcoinpedga>();
        }

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string NumParte { get; set; }
        public int Um { get; set; }
        public int TipoProd { get; set; }
        public short LineaVta { get; set; }
        public short LineaAgrupa { get; set; }
        public int AgrupaExist { get; set; }
        public decimal? Capacidad { get; set; }
        public decimal? Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal? PrecioAnt { get; set; }
        public decimal? PrecioMostrador { get; set; }
        public decimal PrecioPiso { get; set; }
        public DateTime? FechaCambioPrecio { get; set; }
        public short? TiempoEnt { get; set; }
        public int Proveedor { get; set; }
        public string Clasificacion { get; set; }
        public int? CodElect { get; set; }
        public bool Codigo8020 { get; set; }
        public string Origen { get; set; }
        public int? CvePoliza { get; set; }
        public string CveOxidom { get; set; }
        public string Varios { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? Thermo { get; set; }
        public string DescLarga { get; set; }
        public string Moneda { get; set; }
        public string Exportacion { get; set; }
        public int? CodigoDotacion { get; set; }
        public bool AfectaDota { get; set; }
        public bool? PantallaMedidas { get; set; }
        public string CodBar { get; set; }
        public decimal? EmpaqueProv { get; set; }
        public decimal? EmpaqueSuc { get; set; }
        public decimal? EmpaqueVta { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }
        public decimal? Alto { get; set; }
        public decimal? Volumen { get; set; }
        public decimal? UnidadEmp { get; set; }
        public decimal? Peso { get; set; }
        public int? TipoEnvase { get; set; }
        public decimal? Ivaproducto { get; set; }
        public bool? Ivaespecial { get; set; }
        public bool Activo { get; set; }
        public bool CapturaSerie { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string CodigoSat { get; set; }
        public string AlmacenSap { get; set; }
        public short? FamServicio { get; set; }
        public short? PerfilClas { get; set; }
        public short? SubtipoEnv { get; set; }
        public short? ValvulaEnv { get; set; }
        public string Imagen { get; set; }
        public string OrgCompraSap { get; set; }
        public string JerarquiaSap { get; set; }
        public bool? CompraCorpo { get; set; }
        public string Material { get; set; }
        public string Tecnologia { get; set; }
        public string NaturalezaQuim { get; set; }

        public virtual Tcgrlinea LineaVtaNavigation { get; set; }
        public virtual Tccointenv TipoEnvaseNavigation { get; set; }
        public virtual Tccointprod TipoProdNavigation { get; set; }
        public virtual Tccoinum UmNavigation { get; set; }
        public virtual Tccoinprodclave VariosNavigation { get; set; }
        public virtual Tmcooxproducto Tmcooxproducto { get; set; }
        public virtual ICollection<Tccoctporcodpreesp> Tccoctporcodpreesps { get; set; }
        public virtual ICollection<Tccofapromomayoreo> Tccofapromomayoreos { get; set; }
        public virtual ICollection<Tccoinproddescuento> Tccoinproddescuentos { get; set; }
        public virtual ICollection<Tdcoendotideal> Tdcoendotideals { get; set; }
        public virtual ICollection<Tdcoininventariomer> Tdcoininventariomers { get; set; }
        public virtual ICollection<Tdcoinmovscodnogen> Tdcoinmovscodnogens { get; set; }
        public virtual ICollection<Tdcoinmovscod> Tdcoinmovscods { get; set; }
        public virtual ICollection<Tdcoinprodbar> Tdcoinprodbars { get; set; }
        public virtual ICollection<Tdconocomg> Tdconocomgs { get; set; }
        public virtual ICollection<Tdcooxequiposye> Tdcooxequiposyes { get; set; }
        public virtual ICollection<Thcoinayb> Thcoinaybs { get; set; }
        public virtual ICollection<Thcoinmov> Thcoinmovs { get; set; }
        public virtual ICollection<Tmcoctpreesp> Tmcoctpreesps { get; set; }
        public virtual ICollection<Tmcoctremisione> Tmcoctremisiones { get; set; }
        public virtual ICollection<Tmcoctsolpreesp> Tmcoctsolpreesps { get; set; }
        public virtual ICollection<Tmcoeninventario> Tmcoeninventarios { get; set; }
        public virtual ICollection<Tmcoenv01> Tmcoenv01s { get; set; }
        public virtual ICollection<TmcoenvcampLm> TmcoenvcampLms { get; set; }
        public virtual ICollection<TmcoenvcampNc> TmcoenvcampNcs { get; set; }
        public virtual ICollection<Tmcoenvremisione> Tmcoenvremisiones { get; set; }
        public virtual ICollection<Tmcofacodprodcte> Tmcofacodprodctes { get; set; }
        public virtual ICollection<Tmcoinprod02> Tmcoinprod02s { get; set; }
        public virtual ICollection<Tmcoinprodexp> Tmcoinprodexps { get; set; }
        public virtual ICollection<Tmcoinproduccion> Tmcoinproduccions { get; set; }
        public virtual ICollection<Ttcoinpedga> Ttcoinpedgas { get; set; }
    }
}
