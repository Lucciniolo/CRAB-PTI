using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Visite
    {
        private string etat; /* "p" pour programmée "a" pour affecté "r" pour réalisée  switch !!!*/
        private int dureeTotale;
        private Station laStation;
        private List<Borne> lesBornes;
       
       /* private Technicien leTechQuiSenCharge;*/

        #region GET & SET

      /*  public Technicien LeTechQuiSenCharge
        {
            get { return leTechQuiSenCharge; }
            set { leTechQuiSenCharge = value; }
        }*/
        
        public Station LaStation
        {
            get { return laStation; }
            set { laStation = value; }
        }
        public string Etat
        {
            get { return etat; }
            set { etat = value; }
        }
        public int DureeTotale
        {
            get { return dureeTotale; }
            set { dureeTotale = value; }
        }
        public void changerEtat()
        {
            if (this.Etat == "p") this.Etat = "a";
            else this.Etat = "r";

        }


        #endregion

        #region Constructeur
        public Visite()
        { }
        public Visite(string unEtat, int uneDuree, Station uneStation)
        {

        }
        /* Constructeur des visite programmées */
        public Visite(List<Borne> desBornes, Station uneStation)
        {
            if (desBornes != null)
            {
            this.etat = "p";
            this.dureeTotale = 0;
            
                foreach (Borne uneBorne in desBornes)
                {
                    this.dureeTotale = this.dureeTotale + uneBorne.getDureeRevision();
                }
                this.lesBornes = desBornes;
            }
            this.laStation = uneStation;
        }
        #endregion
        
    }
}
