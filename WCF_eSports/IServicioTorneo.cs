using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioTorneo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioTorneo
    {
        [OperationContract]
        List<TorneoBE> FechaTorneo(DateTime FecIni, DateTime FecFin);

        [OperationContract]
        List<TorneoEquipos> ListarTorneosEquipos(Int16 IdEquipo);

        [OperationContract]
        List<PuestoTorneo> ListarPuestoTorneo(Int16 Puesto);

        [OperationContract]
        List<TorneoBE> GetAllTorneo();
    }

    [DataContract]
    [Serializable]
    public class TorneoBE
    {
        private Int16 mvarIdTorneo;
        private String mvarNomTorneo;
        private String mvarOrgTorneo;
        private String mvarPaisTorneo;
        private String mvarLugarTorneo;
        private DateTime mvarFec;

        [DataMember]
        public Int16 IdTorneo
        {
            get { return mvarIdTorneo; }
            set { mvarIdTorneo = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return mvarNomTorneo; }
            set { mvarNomTorneo = value; }
        }
        [DataMember]
        public String Org
        {
            get { return mvarOrgTorneo; }
            set { mvarOrgTorneo = value; }
        }
        [DataMember]
        public String Pais
        {
            get { return mvarPaisTorneo; }
            set { mvarPaisTorneo = value; }
        }
        [DataMember]
        public String Lugar
        {
            get { return mvarLugarTorneo; }
            set { mvarLugarTorneo = value; }
        }
        
    }

    [DataContract]
    [Serializable]
    public class TorneoEquipos
    {
        private String mvarNomTorneo;
        private String mvarPaisTorneo;
        private String mvarLugarTorneo;
        private Int16 mvarPuesto;

        [DataMember]
        public String NomTorneo
        {
            get { return mvarNomTorneo; }
            set { mvarNomTorneo = value; }
        }

        [DataMember]
        public String PaisTorneo
        {
            get { return mvarPaisTorneo; }
            set { mvarPaisTorneo = value; }
        }

        [DataMember]
        public String LugarTorneo
        {
            get { return mvarLugarTorneo; }
            set { mvarLugarTorneo = value; }
        }

        [DataMember]
        public Int16 Puesto
        {
            get { return mvarPuesto; }
            set { mvarPuesto = value; }
        }

    }

    [DataContract]
    [Serializable]
    public class PuestoTorneo
    {
        private String mvarNomTorneo;
        private String mvarPaisTorneo;
        //private String mvarLugarTorneo;
        private String mvarNomEquipo;
        private String mvarPaisEquipo;
        private Int16 mvarVictorias;
        private Int16 mvarDerrotas;

        [DataMember]
        public String NomTorneo
        {
            get { return mvarNomTorneo; }
            set { mvarNomTorneo = value; }
        }

        [DataMember]
        public String PaisTorneo
        {
            get { return mvarPaisTorneo; }
            set { mvarPaisTorneo = value; }
        }

        //[DataMember]
        //public String LugarTorneo
        //{
        //    get { return mvarLugarTorneo; }
        //    set { mvarLugarTorneo = value; }
        //}

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
    }
}
