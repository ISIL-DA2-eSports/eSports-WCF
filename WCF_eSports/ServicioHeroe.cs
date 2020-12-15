using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioHeroe" en el código y en el archivo de configuración a la vez.
    public class ServicioHeroe : IServicioHeroe
    {
        public List<HeroeBE> HeroeComplejidad(String complejidad)
        {
            eSportsEntities entity = new eSportsEntities();
            try
            {
                List<HeroeBE> objLista = new List<HeroeBE>();

                var query = entity.ConsultarHeroeComplejidad1(complejidad);

                foreach (var item in query)
                {
                    HeroeBE objItem = new HeroeBE();
                    objItem.Id = Convert.ToInt16(item.idHeroe);
                    objItem.Nombre = item.NomHeroe;
                    objItem.Atributo = item.Atributo;
                    objItem.Tipo = item.Tipo;
                    objItem.Complejidad = item.Complejidad;

                    objLista.Add(objItem);
                }
                return objLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<HeroeConteo> HeroePorcentaje(Int16 IdTorneo)
        {
            try
            {
                eSportsEntities entities = new eSportsEntities();
                List<HeroeConteo> objLista = new List<HeroeConteo>();

                var query = entities.usp_HeroesPorcentaje(IdTorneo);

                foreach (var item in query)
                {
                    HeroeConteo objItem = new HeroeConteo();
                    objItem.NomHeroe = item.NomHeroe;
                    objItem.ConHeroe = Convert.ToInt16(item.HeroCount);
                    objItem.Porcentaje = item.Porcentaje;

                    objLista.Add(objItem);
                }

                return objLista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<HeroeRol> HeroeJugadorRoles(Int16 IdHeroe, String RolJugador)
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<HeroeRol> objLista = new List<HeroeRol>();

                var query = entity.usp_ListarHeroeRol(IdHeroe, RolJugador);

                foreach(var item in query)
                {
                    HeroeRol objItem = new HeroeRol();
                    objItem.IdPartida = Convert.ToInt16(item.IdPartida);
                    objItem.IdJugador = Convert.ToInt16(item.IdJugador);
                    //objItem.Round = item.RoundJugador;
                    objItem.Nickname = item.NickJugador;
                    objItem.IdHeroe = Convert.ToInt16(item.IdHeroe);
                    objItem.NomHeroe = item.NomHeroe;
                    objItem.Kills = Convert.ToInt16(item.Kills);
                    objItem.Deaths = Convert.ToInt16(item.Deaths);
                    objItem.Assists = Convert.ToInt16(item.Assists);

                    objLista.Add(objItem);
                }

                return objLista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<HeroeBE> GetAllHeroes()
        {
            eSportsEntities entity = new eSportsEntities();

            try
            {
                List<HeroeBE> objListaHeroes = new List<HeroeBE>();

                var query = (from objHeroe in entity.HEROE
                             select objHeroe);

                foreach (var objHeroeConsultar in query)
                {
                    HeroeBE objHeroeBE = new HeroeBE();
                    objHeroeBE.Id = Convert.ToInt16(objHeroeConsultar.IdHeroe);
                    objHeroeBE.Nombre = objHeroeConsultar.NomHeroe;
                    objHeroeBE.Atributo = objHeroeConsultar.Atributo;
                    objHeroeBE.Tipo = objHeroeConsultar.Tipo;
                    objHeroeBE.Complejidad = objHeroeConsultar.Complejidad;

                    objListaHeroes.Add(objHeroeBE);

                }
                return objListaHeroes;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
