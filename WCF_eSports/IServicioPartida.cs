using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPartida" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPartida
    {
        [OperationContract]
        List<PartidaBE> GetAllPartida();
    }
    [DataContract]
    [Serializable]
    public class PartidaBE
    {
        private Int16 mvarIdPartida;
        private String mvarRoundPartida;

        [DataMember]
        public Int16 IdPartida
        {
            get { return mvarIdPartida; }
            set { mvarIdPartida = value; }
        }

        [DataMember]
        public String RoundPartida
        {
            get { return mvarRoundPartida; }
            set { mvarRoundPartida = value; }
        }
    }
}
