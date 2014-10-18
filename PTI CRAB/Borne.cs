using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Borne
    {
        private int idBorne, indiceCompteurUnités;      
        private DateTime dateDerniereRevision;    
        private TypeBorne leType;

        #region GET & SET
        public int IndiceCompteurUnités
        {
            get { return indiceCompteurUnités; }
            set { indiceCompteurUnités = value; }
        }
        public int IdBorne
        {
            get { return idBorne; }
            set { idBorne = value; }
        }
        public DateTime DateDerniereRevision
        {
            get { return dateDerniereRevision; }
            set { dateDerniereRevision = value; }
        }
        public TypeBorne LeType
        {
            get { return leType; }
            set { leType = value; }
        }
        #endregion

        #region Constructeur
        public Borne()
        { }

        public Borne(int unId, int unIndice, TypeBorne unType)
        {
            this.idBorne = unId;
            this.indiceCompteurUnités = unIndice;
            this.leType = unType;


        }

        public Borne(int unId, int unIndice, DateTime uneDate, TypeBorne unType)
        {
            this.idBorne = unId;
            this.indiceCompteurUnités = unIndice;
            this.dateDerniereRevision = uneDate;
            this.leType = unType;
        }
        #endregion

        #region Methodes publiques
        public int getDureeRevision()
        {
            return (this.leType.DuréeRévision);
        }

        public bool estAReviser()
        {
            bool res = false;
            DateTime date = new DateTime();
            DateTime aujourdui = new DateTime(date.Year, date.Month, date.Day);
            aujourdui = DateTime.Now;
            TimeSpan duree = aujourdui.Subtract(this.dateDerniereRevision);
            double nbjours = duree.TotalDays;

            double nbJoursRevision = this.leType.NbJoursEntreRevisionns;
            if (this.indiceCompteurUnités >= this.leType.NbUnitesEntreRevisions) res = true;
            if (nbjours >= nbJoursRevision) res = true; 

            return res;

        }
        #endregion

    }
}
