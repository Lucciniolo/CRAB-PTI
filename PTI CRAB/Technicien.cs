using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Technicien
    {
        private int matricule;       
        private string nom, prenom;
        private List<Visite> lesVisites = new List<Visite>();

        #region Constructeur
        public Technicien()
        { }

        public Technicien(int unId, string unNom, string unPrenom)
        {
            this.matricule = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
        }
        public Technicien(int unId, string unNom, string unPrenom, List<Visite> desVisites)
        {
            this.matricule = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.lesVisites = desVisites;
        }
        #endregion
        
        #region GET & SET 
        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public List<Visite> LesVisites
        {
            get { return lesVisites; }
        }
        #endregion

        #region Methodes publiques
        public int getTempsOccupé()
        {
            int tps = 0;
            foreach (Visite uneVisite in this.lesVisites)
            {
                tps = tps + uneVisite.DureeTotale;
            }
            return tps;
        }

        public void affecterVisite(Visite uneVisite)
        {
            this.lesVisites.Add(uneVisite);
        }
        #endregion



    }
}
