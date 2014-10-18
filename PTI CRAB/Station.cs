using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Station
    {
        private int idStation;
        private string libelleEmplacement;
        private List<Borne> lesBornes = new List<Borne>();

        #region  Constructeur
        public Station()
        { }
        public Station(int unId, string unEmplacement)
        {
            this.idStation = unId;
            this.libelleEmplacement = unEmplacement;
        }
        public Station(int unId, string unEmplacement, List<Borne> desBornes)
        {
            this.idStation = unId;
            this.libelleEmplacement = unEmplacement;
            this.lesBornes = desBornes;
        }
        #endregion

        #region GET & SET
        public int IdStation
        {
            get { return idStation; }
            set { idStation = value; }
        }
        public string LibelleEmplacement
        {
            get { return libelleEmplacement; }
            set { libelleEmplacement = value; }
        }
        public List<Borne> LesBornes
        {
            get { return lesBornes; }
            set { lesBornes = value; }
        }
        #endregion

        #region Methodes publiques
        public Visite getVisiteAFaire()
        {
            List<Borne> LesBornesAReviser = new List<Borne>(); ;
            Visite laVisite = new Visite();
            laVisite = null;

            if (this.lesBornes != null)
            {
                foreach (Borne uneBorne in lesBornes)
                {
                    if (uneBorne.estAReviser() == true) 
                        LesBornesAReviser.Add(uneBorne);
                }
                if (LesBornesAReviser.Count != 0) 
                    laVisite = new Visite(LesBornesAReviser, this);
            }
            return (laVisite);

        }

        public int nbBornesAReviser()
        {
            int i = 0;
            foreach (Borne uneBorne in lesBornes)
            {
                if (uneBorne.estAReviser() == true) i++;
            }
            return i;
        }
        #endregion

    }
}
