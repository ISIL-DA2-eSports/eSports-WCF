using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioJugador" en el código y en el archivo de configuración a la vez.
    public class ServicioJugador : IServicioJugador
    {
        public List<JugadorEstadistica> RankingJugador(Int16 top)
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<JugadorEstadistica> objLista = new List<JugadorEstadistica>();

                var query = (from obj in entity.vw_RankingKillsPorPartida
                             select new
                             {
                                 obj.RoundPartida,
                                 obj.NickJugador,
                                 obj.NomHeroe,
                                 obj.TotalKills,
                                 obj.TotalDeaths,
                                 obj.TotalAssists
                             }).Take(top);
                foreach (var item in query)
                {
                    JugadorEstadistica objItem = new JugadorEstadistica();
                    objItem.Round = item.RoundPartida;
                    objItem.Nickname = item.NickJugador;
                    objItem.NomHeroe = item.NomHeroe;
                    objItem.TotalKills = Convert.ToSingle(item.TotalKills);
                    objItem.TotalDeaths = Convert.ToSingle(item.TotalDeaths);
                    objItem.TotalAssists = Convert.ToSingle(item.TotalAssists);

                    objLista.Add(objItem);
                }
                return objLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<JugadorBE> ListarPaisJugadores(String pais)
        {
            eSportsEntities entity = new eSportsEntities();
            try
            {
                List<JugadorBE> objListaJugador = new List<JugadorBE>();
                var query = (from JUGADOR in entity.JUGADOR
                                                    where JUGADOR.PaisJugador == pais
                                                    select JUGADOR);
                foreach(var objJugadorConsultar in query)
                { 
                    JugadorBE objItem = new JugadorBE();
                    objItem.Apellido = objJugadorConsultar.ApeJugador;
                    objItem.Nombre = objJugadorConsultar.NomJugador;
                    objItem.NickName = objJugadorConsultar.NickJugador;
                    objItem.Pais = objJugadorConsultar.PaisJugador;
                    objItem.Rol = objJugadorConsultar.RolJugador;
                    objItem.Equipo = objJugadorConsultar.EQUIPO.NomEquipo;

                    objListaJugador.Add(objItem);
                }
                return objListaJugador;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<JugadorBE> ListarJugadoresPorEdad(Int16 edad)
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<JugadorBE> objLista = new List<JugadorBE>();
                var query = entity.usp_EdadJugador1(edad);
            
                foreach (var item in query)
                {
                    JugadorBE objItem = new JugadorBE();
                    objItem.Apellido = item.ApeJugador;
                    objItem.Nombre = item.NomJugador;
                    objItem.NickName = item.NickJugador;
                    objItem.Pais = item.PaisJugador;
                    objItem.Edad = Convert.ToInt16(item.EdadJugador);

                    objLista.Add(objItem);
                }
                return objLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
