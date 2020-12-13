using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioTorneo" en el código y en el archivo de configuración a la vez.
    public class ServicioTorneo : IServicioTorneo
    {
        public List<TorneoBE> FechaTorneo(DateTime FecIni, DateTime FecFin)
        {
            eSportsEntities entity = new eSportsEntities();
            try
            {
                List<TorneoBE> objLista = new List<TorneoBE>();

                var query = entity.ConsultarFechaTorneo(FecIni, FecFin);

                foreach (var item in query)
                {
                    TorneoBE objItem = new TorneoBE();
                    objItem.Nombre = item.NomTorneo;
                    objItem.Org = item.OrgTorneo;
                    objItem.Pais = item.PaisTorneo;
                    objItem.Lugar = item.LugarTorneo;
                    

                    objLista.Add(objItem);
                }
                return objLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TorneoEquipos> ListarTorneosEquipos(Int16 IdEquipo)
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<TorneoEquipos> objLista = new List<TorneoEquipos>();

                var query = entity.usp_TorneosPorEquipo(IdEquipo);

                foreach(var item in query)
                {
                    TorneoEquipos objItem = new TorneoEquipos();
                    objItem.NomTorneo = item.NomTorneo;
                    objItem.PaisTorneo = item.PaisTorneo;
                    objItem.LugarTorneo = item.LugarTorneo;
                    objItem.Puesto = Convert.ToInt16(item.Puesto);

                    objLista.Add(objItem);

                }
                return objLista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<PuestoTorneo> ListarPuestoTorneo(Int16 Puesto)
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<PuestoTorneo> objLista = new List<PuestoTorneo>();

                var query = entity.usp_PuestoPorTorneo(Puesto);

                foreach(var item in query)
                {
                    PuestoTorneo objItem = new PuestoTorneo();
                    objItem.NomTorneo = item.NomTorneo;
                    objItem.PaisTorneo = item.PaisTorneo;
                    //objItem.LugarTorneo = item.LugarTorneo;
                    objItem.NomEquipo = item.NomEquipo;
                    objItem.PaisEquipo = item.PaisEquipo;
                    objItem.Victorias = Convert.ToInt16(item.Victorias);
                    objItem.Derrotas = Convert.ToInt16(item.Derrotas);

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
