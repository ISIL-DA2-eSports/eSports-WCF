﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class eSportsEntities : DbContext
    {
        public eSportsEntities()
            : base("name=eSportsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DETALLE_EQUIPO> DETALLE_EQUIPO { get; set; }
        public virtual DbSet<DETALLE_JUGADOR_PARTIDA> DETALLE_JUGADOR_PARTIDA { get; set; }
        public virtual DbSet<DETALLE_PERSONAL> DETALLE_PERSONAL { get; set; }
        public virtual DbSet<EQUIPO> EQUIPO { get; set; }
        public virtual DbSet<HEROE> HEROE { get; set; }
        public virtual DbSet<JUEGO> JUEGO { get; set; }
        public virtual DbSet<JUGADOR> JUGADOR { get; set; }
        public virtual DbSet<PARTIDA> PARTIDA { get; set; }
        public virtual DbSet<PERSONAL> PERSONAL { get; set; }
        public virtual DbSet<PRIZEPOOL> PRIZEPOOL { get; set; }
        public virtual DbSet<PUESTO_PRIZEPOOL> PUESTO_PRIZEPOOL { get; set; }
        public virtual DbSet<TORNEO> TORNEO { get; set; }
        public virtual DbSet<vw_RankingKillsPorPartida> vw_RankingKillsPorPartida { get; set; }
    
        public virtual ObjectResult<usp_KillsEquipoPorPartida_Result> usp_KillsEquipoPorPartida(Nullable<int> partida)
        {
            var partidaParameter = partida.HasValue ?
                new ObjectParameter("partida", partida) :
                new ObjectParameter("partida", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_KillsEquipoPorPartida_Result>("usp_KillsEquipoPorPartida", partidaParameter);
        }
    }
}
