//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_eSports
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_RankingKillsPorPartida
    {
        public int IdPartida { get; set; }
        public string RoundPartida { get; set; }
        public string NickJugador { get; set; }
        public string NomHeroe { get; set; }
        public Nullable<int> TotalKills { get; set; }
        public Nullable<int> TotalDeaths { get; set; }
        public Nullable<int> TotalAssists { get; set; }
    }
}
