using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEquipo" en el código y en el archivo de configuración a la vez.
    public class ServicioEquipo : IServicioEquipo
    {
        public List<EquipoPuntos> RankingEquipoPartida(Int16 partida)
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<EquipoPuntos> objLista = new List<EquipoPuntos>();

                var query = entity.usp_KillsEquipoPorPartida(partida);

                foreach (var item in query)
                {
                    EquipoPuntos objItem = new EquipoPuntos();
                    objItem.Enfrentamiento = item.Enfrentamiento;
                    objItem.Equipo = item.NomEquipo;
                    objItem.Resultado = Convert.ToSingle(item.Resultado);

                    objLista.Add(objItem);
                }
                return objLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PremioEquipo> AsignarGanancia(Int16 IdTorneo, Decimal Monto)
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<PremioEquipo> objLista = new List<PremioEquipo>();

                var query = entity.usp_GananciaTorneo(IdTorneo, Monto);

                foreach(var item in query)
                {
                    PremioEquipo objItem = new PremioEquipo();
                    objItem.NomEquipo = item.NomEquipo;
                    objItem.Puesto = Convert.ToInt16(item.Puesto);
                    objItem.Ganancia = Convert.ToDecimal(item.Ganancia);

                    objLista.Add(objItem);
                }
                return objLista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<EquipoPuestos> PuestoTorneo(Int16 IdTorneo)
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<EquipoPuestos> objLista = new List<EquipoPuestos>();

                var query = entity.usp_PuestosEquipos(IdTorneo);

                foreach(var item in query)
                {
                    EquipoPuestos objItem = new EquipoPuestos();
                    objItem.Puesto = Convert.ToInt16(item.Puesto);
                    objItem.NomEquipo = item.Nombre_de_Equipo;
                    objItem.Victorias = Convert.ToInt16(item.Victorias);
                    objItem.Derrotas = Convert.ToInt16(item.Derrotas);
                    objItem.Torneo = item.NomTorneo;

                    objLista.Add(objItem);
                }
                return objLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EquipoBE> GetAllEquipo()
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<EquipoBE> objListaEquipo = new List<EquipoBE>();

                var query = (from objEquipo in entity.EQUIPO
                             select objEquipo);

                foreach (var objEquipoConsultar in query)
                {
                    EquipoBE objEquipoBE = new EquipoBE();
                    objEquipoBE.IdEquipo = Convert.ToInt16(objEquipoConsultar.IdEquipo);
                    objEquipoBE.NomEquipo = objEquipoConsultar.NomEquipo;
                    objEquipoBE.PaisEquipo = objEquipoConsultar.PaisEquipo;

                    objListaEquipo.Add(objEquipoBE);
                }

                return objListaEquipo;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
