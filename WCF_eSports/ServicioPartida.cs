using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPartida" en el código y en el archivo de configuración a la vez.
    public class ServicioPartida : IServicioPartida
    {
        public List<PartidaBE> GetAllPartida()
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<PartidaBE> objListaPartida = new List<PartidaBE>();

                var query = (from objPartida in entity.PARTIDA
                             select objPartida);

                foreach (var objPartidaConsultar in query)
                {
                    PartidaBE objPartidaBE = new PartidaBE();
                    objPartidaBE.IdPartida = Convert.ToInt16(objPartidaConsultar.IdPartida);
                    objPartidaBE.RoundPartida = objPartidaConsultar.RoundPartida;

                    objListaPartida.Add(objPartidaBE);
                }
                return objListaPartida;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
