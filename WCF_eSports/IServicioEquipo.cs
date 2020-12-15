using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEquipo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEquipo
    {
        [OperationContract]
        List<EquipoPuntos> RankingEquipoPartida(Int16 partida);

        [OperationContract]
        List<PremioEquipo> AsignarGanancia(Int16 IdTornero, Decimal Monto);

        [OperationContract]
        List<EquipoPuestos> PuestoTorneo(Int16 IdTorneo);

        [OperationContract]
        List<EquipoBE> GetAllEquipo();
    }

    [DataContract]
    [Serializable]
    public class EquipoBE
    {
        private Int16 mvarIdEquipo;
        private String mvarNomEquipo;
        private String mvarPaisEquipo;

        [DataMember]
        public Int16 IdEquipo
        {
            get { return mvarIdEquipo; }
            set { mvarIdEquipo = value; }
        }

        [DataMember]
        public String NomEquipo
        {
            get { return mvarNomEquipo; }
            set { mvarNomEquipo = value; }
        }

        [DataMember]
        public String PaisEquipo
        {
            get { return mvarPaisEquipo; }
            set { mvarPaisEquipo = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class EquipoPuntos
    {
        private String mvarenfrentamiento;
        private String mvarequipo;
        private Single mvarresultado;
        [DataMember]
        public String Enfrentamiento
        {
            get { return mvarenfrentamiento; }
            set { mvarenfrentamiento = value; }
        }
        [DataMember]
        public String Equipo
        {
            get { return mvarequipo; }
            set { mvarequipo = value; }
        }
        [DataMember]
        public Single Resultado
        {
            get { return mvarresultado; }
            set { mvarresultado = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class PremioEquipo
    {
        private String mvarNomEquipo;
        private Int16  mvarPuesto;
        private Decimal mvarGanancia;
        [DataMember]
        public String NomEquipo
        {
            get { return mvarNomEquipo; }
            set { mvarNomEquipo = value; }
        }
        [DataMember]
        public Int16 Puesto
        {
            get { return mvarPuesto; }
            set { mvarPuesto = value; }
        }
        [DataMember]
        public Decimal Ganancia
        {
            get { return mvarGanancia; }
            set { mvarGanancia = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class EquipoPuestos
    {
        private Int16 mvarPuesto;
        private String mvarNomEquipo;
        private Int16 mvarVictorias;
        private Int16 mvarDerrotas;
        private String mvarTorneo;

        [DataMember]
        public Int16 Puesto
        {
            get { return mvarPuesto; }
            set { mvarPuesto = value; }
        }
        [DataMember]
        public String NomEquipo
        {
            get { return mvarNomEquipo; }
            set { mvarNomEquipo = value; }
        }
        [DataMember]
        public Int16 Victorias
        {
            get { return mvarVictorias; }
            set { mvarVictorias = value; }
        }
        [DataMember]
        public Int16 Derrotas
        {
            get { return mvarDerrotas; }
            set { mvarDerrotas = value; }
        }
        [DataMember]
        public String Torneo
        {
            get { return mvarTorneo; }
            set { mvarTorneo = value; }
        }
    }
}
