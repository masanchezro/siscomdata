using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoaftransporteinv
    {
        public int NumAct { get; set; }
        public short Sucursal { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string NoTarjetaDasoliaDiesel { get; set; }
        public string NombreChoferaCargoUnidad { get; set; }
        public string Nomina { get; set; }
        public string UsoOxidom { get; set; }
        public string UsoGases { get; set; }
        public string UsoMercancias { get; set; }
        public string UsoLiquidos { get; set; }
        public string Kilometraje { get; set; }
        public string DondeTransita { get; set; }
        public string Comentarios { get; set; }
    }
}
