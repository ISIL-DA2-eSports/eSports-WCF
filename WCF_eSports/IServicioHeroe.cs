using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioHeroe" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioHeroe
    {
        [OperationContract]
        List<HeroeBE> HeroeComplejidad(String complejidad);

        [OperationContract]
        List<HeroeConteo> HeroePorcentaje(Int16 IdTorneo);

        [OperationContract]
        List<HeroeRol> HeroeJugadorRoles(Int16 IdHeroe, String RolJugador);

        [OperationContract]
        List<HeroeBE> GetAllHeroes();
        
    }

    [DataContract]
    [Serializable]
    public class HeroeBE
    {
        private Int16 mvarId;
        private String mvarNombre;
        private String mvarAtributo;
        private String mvarTipo;
        private String mvarComplejidad;
        [DataMember]
        public Int16 Id
        {
            get { return mvarId; }
            set { mvarId = value; }
        }
        [DataMember]
        public String Nombre
        {
            get { return mvarNombre; }
            set { mvarNombre = value; }
        }
        [DataMember]
        public String Atributo
        {
            get { return mvarAtributo; }
            set { mvarAtributo = value; }
        }
        [DataMember]
        public String Tipo
        {
            get { return mvarTipo; }
            set { mvarTipo = value; }
        }

        [DataMember]
        public String Complejidad
        {
            get { return mvarComplejidad; }
            set { mvarComplejidad = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class HeroeConteo
    {
        private String mvarNomHeroe;
        private Int16 mvarContHeroe;
        private String mvarPorcentaje;

        [DataMember]
        public String NomHeroe
        {
            get { return mvarNomHeroe; }
            set { mvarNomHeroe = value; }
        }

        [DataMember]
        public Int16 ConHeroe
        {
            get { return mvarContHeroe; }
            set { mvarContHeroe = value; }
        }

        [DataMember]
        public String Porcentaje
        {
            get { return mvarPorcentaje; }
            set { mvarPorcentaje = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class HeroeRol {
        private Int16 mvarIdPartida;
        private Int16 mvarIdJugador;
        private String mvarRound;
        private String mvarNickname;
        private Int16 mvarIdHeroe;
        private String mvarNomHeroe;
        private Int16 mvarKills;
        private Int16 mvarDeaths;
        private Int16 mvarAssists;

        [DataMember]
        public Int16 IdPartida
        {
            get { return mvarIdPartida; }
            set { mvarIdPartida = value; }
        }

        [DataMember]
        public Int16 IdJugador
        {
            get { return mvarIdJugador; }
            set { mvarIdJugador = value; }
        }

        //[DataMember]
        //public String Round
        //{
        //    get { return mvarRound; }
        //    set { mvarRound = value; }
        //}

        [DataMember]
        public String Nickname
        {
            get { return mvarNickname; }
            set { mvarNickname = value; }
        }
        [DataMember]
        public Int16 IdHeroe
        {
            get { return mvarIdHeroe; }
            set { mvarIdHeroe = value; }
        }
        [DataMember]
        public String NomHeroe
        {
            get { return mvarNomHeroe; }
            set { mvarNomHeroe = value; }
        }
        [DataMember]
        public Int16 Kills
        {
            get { return mvarKills; }
            set { mvarKills = value; }
        }
        [DataMember]
        public Int16 Deaths
        {
            get { return mvarDeaths; }
            set { mvarDeaths = value; }
        }
        [DataMember]
        public Int16 Assists
        {
            get { return mvarAssists; }
            set { mvarAssists = value; }
        }
    }
}
