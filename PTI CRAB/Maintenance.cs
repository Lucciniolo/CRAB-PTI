using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Maintenance
    {
        private List<Station> lesStations = new List<Station>();        
        private List<Technicien> lesTechniciens = new List<Technicien>();  
        private List<Visite> lesVisites = new List<Visite>();
        private List<TypeBorne> lesTypesBornes = new List<TypeBorne>();
        public List<TypeBorne> LesTypesBornes
        {
            get { return lesTypesBornes; }
            set { lesTypesBornes = value; }
        }
 
        Random rndNumbers = new Random(); // Objet permettant de créer un nombre aléatoire
        #region GET & SET

        public List<Station> LesStations
        {
            get { return lesStations; }
            set { lesStations = value; }
        }
        public List<Technicien> LesTechniciens
        {
            get { return lesTechniciens; }
            set { lesTechniciens = value; }
        }
        public List<Visite> LesVisites
        {
            get { return lesVisites; }
            set { lesVisites = value; }
        }

        #endregion

        #region Contstructeur

        public Maintenance()
        {

        }
        /* Constructeur Simu */
        public Maintenance(List<Station> desStations, List<Technicien> desTechniciens, List<TypeBorne> desTypes)
        {
            this.lesStations = desStations;
            this.lesTechniciens = desTechniciens;
            this.lesTypesBornes =  desTypes;
        }
        /* Constructeur BD ou serialisation */
        public Maintenance(List<Station> desStations, List<Technicien> desTechniciens, List<Visite> desVisites)
        {
            this.lesStations = desStations;
            this.lesTechniciens = desTechniciens;
            this.lesVisites = desVisites;
        }
        #endregion

        #region Methodes publiques

        #region Autres
        /* Génere les visite à faire */
        public void GenereVisitesP()
        {
            Visite uneVisite = new Visite();
            foreach (Station laStation in lesStations)
            {
                uneVisite = laStation.getVisiteAFaire();
                if (laStation.getVisiteAFaire() != null) /* Permet d'ajouter strictement que les visite à faire  */
                    lesVisites.Add(uneVisite);
            }
        }

        /* Permet d'affecter les visites aux techniciens selon leur tps de travail */
        public void affecterVisite()
        {
            foreach (Visite uneVisite in lesVisites)
            {
                if (uneVisite.Etat == "p")
                {
                    uneVisite.changerEtat();
                    Technicien unTech = this.TechMoinsCharge();

                    unTech.affecterVisite(uneVisite);
                  /*  uneVisite.LeTechQuiSenCharge = unTech;*/
                    
                }
            }
        }
     
        /* Retourne le technicien ayant le moins de tps de travail */
        public Technicien TechMoinsCharge()
        {
            Technicien leMin, leTech;
            leMin = this.lesTechniciens[0];
            int nbTech = this.lesTechniciens.Count - 1;

            for (int i = 1; i <= nbTech; i++)
            {
                leTech = this.lesTechniciens[i];
                int leTechTps = leTech.getTempsOccupé(); 
                if (leTechTps  < leMin.getTempsOccupé())
                    leMin = leTech;
            }

            return leMin;
        }

        /* Permet de supprimer une visite lorsqu'elle a été réalisée (lorsque l'on clique sur completer=>realiser */
        public void realiserVisite(Visite uneVisite)
        {
            foreach (Borne uneBorne in uneVisite.LaStation.LesBornes)
            {
                uneBorne.IndiceCompteurUnités = 0;   /* Je remet son indice d'unité à 0 */
                DateTime aujourdhui = new DateTime();
                aujourdhui = DateTime.Now;
                uneBorne.DateDerniereRevision = aujourdhui; /* et je change la date de dernière à celle d'aujourd'hui */
            }
                
            this.TechDelaVisite(uneVisite).LesVisites.Remove(uneVisite); /* Je supprime ici la visite passé en paramettre dans la collection de visite du technicien ayant réalisée la visite */

            this.lesVisites.Remove(uneVisite); /* Je supprime ici la visite passé en paramettre dans la collection de visite de l'application */         
        }

        /* Permet de retourner le Technicien affectér à une viste  */
        public Technicien TechDelaVisite(Visite uneVisite)
        {
            Technicien leTech = new Technicien();

            foreach (Technicien unTech in lesTechniciens)
            {
                foreach (Visite uneAutreVisite in unTech.LesVisites)
                {
                    if (uneVisite.LaStation.IdStation == uneAutreVisite.LaStation.IdStation) leTech = unTech;
                }
            }
            return leTech;
        }

        #endregion

        #region Affichage
        /* Permet de lier des visites à une listbox */
   
        public void lierVisites(ListBox lb, List<Visite> desVisites)
        {
            lb.Items.Clear();
            
            
            foreach (Visite uneVisite in desVisites)
            {
                string etat = "Aucun technicien n'en a la charge.";
                Technicien tech = TechDelaVisite(uneVisite);
                if (uneVisite.Etat == "a") etat = "Un technicien s'en charge : " + this.TechDelaVisite(uneVisite).Nom + " " + this.TechDelaVisite(uneVisite).Prenom;
                if (uneVisite.Etat == "r") etat = " a été réalisé";
                lb.Items.Add("Station :" + uneVisite.LaStation.LibelleEmplacement + ". " + etat );
            }
        }

        /* Permet de lier les techniciens à une listbox */
        public void lierTechniciens(ListBox lb)
        {
            lb.Items.Clear();
            foreach (Technicien unTech in this.lesTechniciens)
            {
                lb.Items.Add("ID : " + unTech.Matricule + " | " + unTech.Nom + " " + unTech.Prenom);
            }
        }

        /* Permet de lier les visites d'un technicien à une listbox*/
        public ListBox lierVisitesTech(Technicien unTech, ListBox lb)
        {
            lb.Items.Clear();
            foreach (Visite uneVisite in unTech.LesVisites)
            {
                lb.Items.Add("Visite à " + uneVisite.LaStation.LibelleEmplacement + " sur " + uneVisite.LaStation.LesBornes.Count + " bornes");
            }
            return lb;
        }

        /* Permet de lier les station à une listbox */
        public void lierStations(ListBox lb)
        {
            lb.Items.Clear();
            foreach (Station uneStation in lesStations )
            {
                string etat = " | Etat : Fonctionnel";
                if (uneStation.getVisiteAFaire() != null) etat = " | Etat : A réviser";                
                lb.Items.Add("ID : " + uneStation.IdStation + " | La station de " + uneStation.LibelleEmplacement + etat );
            }
        }

        /* Permet de lier les bornes d'une station à une listbox*/
        public void lierBorneStation(Station uneStation ,ListBox lb)
        {
            lb.Items.Clear();
            if (uneStation.LesBornes != null)
            {
                foreach (Borne uneBorne in uneStation.LesBornes)
                {
                    string etat = " | Etat : Fonctionnel";
                    string duree = "";
                    if (uneBorne.estAReviser() == true)
                    {
                        etat = " | Etat : A réviser";
                        duree = " | Durée de révision " + Convert.ToString(uneBorne.getDureeRevision()) + "mn";
                    }
                    lb.Items.Add("ID : " + uneBorne.IdBorne + " | Type : " + uneBorne.LeType.CodeTypeBorne + etat + duree);
                }
            }
            else lb.Items.Add("Les bornes de cette station n'ont pas encore été renseigné");
        }

        /* Permet de lier les bornes concernées par une viste à une listbox*/
        public void lierBorneVisite(Visite uneVisite, ListBox lb)
        {
               string duree;
                lb.Items.Clear();
                foreach (Borne uneBorne in uneVisite.LaStation.LesBornes)
                {
                    duree = " | Durée de révision " + Convert.ToString(uneBorne.getDureeRevision()) + "mn";                    
                    lb.Items.Add("ID : " + uneBorne.IdBorne + " | Type : " + uneBorne.LeType.CodeTypeBorne + duree);
                }
            }
        #endregion

        #region Ajout & Suppression
        /* Ajoute un tech */
        public void addTech(Technicien unTech)
        {
            this.LesTechniciens.Add(unTech);
        }

        // Suprrimer un technicien. 
        public void delTech(Technicien unTech)
        {
            foreach (Visite uneVisite in lesVisites)
            {
                foreach (Visite uneVtech in unTech.LesVisites)
                {
                    if (uneVisite.LaStation.IdStation == uneVtech.LaStation.IdStation) uneVisite.Etat = "p";
                }
            }
            #region Ancienne methode pour changer l'etat de la visite 
            /*for (int i = 0; i <= nbV; i++)
            {
                Visite uneV = this.lesVisites[i];

                for (int j = 0; j <= nbVT; j++)
                {
                    Visite uneVTech = unTech.LesVisites[j];
                    if (uneV.LaStation.IdStation == uneVTech.LaStation.IdStation) uneV.Etat = "p"; ;
                }
            }*/
            #endregion
            this.LesTechniciens.Remove(unTech);
        }

        /* Ajoute une station */
        public void addStation(Station uneStation)
        {
            this.LesStations.Add(uneStation);
        }

        /* Supprimer une station */
        // Lorsque l'on supprime une station, on doit supprimer la visite qui a été généré automatiquement. 
        // On doit aussi supprimer la visite qu'elle a généré dans la collection de visite du technicien.


        private Visite rechercheVisite(Station uneStation)
        {
            int i = 0;

            while (i < lesVisites.Count && lesVisites[i].LaStation.IdStation != uneStation.IdStation)
                i++;

            if (i < lesVisites.Count && lesVisites[i].LaStation.IdStation == uneStation.IdStation)
                return lesVisites[i];

            return null;
        }

        public void delStation(Station uneStation)
        {
           Visite laVisite = rechercheVisite(uneStation);

          TechDelaVisite(laVisite).LesVisites.Remove(laVisite);
          lesVisites.Remove(laVisite);
          lesStations.Remove(uneStation);
        }  

        /* Ajoute une borne */
        public void addBorne(Borne uneBorne, int indexStation)
        {        
            this.lesStations[indexStation].LesBornes.Add(uneBorne);       
            
        }

        /* Supprimer  une borne */
        public void delBorne(Borne uneBorne, int indexStation)
        {
            this.lesStations[indexStation].LesBornes.Remove(uneBorne);

        }
        #endregion

        #region Simulation
        private TypeBorne randomTypeBorne(List<TypeBorne> plesTypesBornes)
        // Retourne un type de borne choisi au hasard
        {
            int nbTypes = plesTypesBornes.Count();

            int nbAleatoire = 0;

            nbAleatoire = rndNumbers.Next(nbTypes);

            return plesTypesBornes[nbAleatoire];


        }

        private DateTime DateAuHasard()
        // Fonction retournant une date au hasard entre une date minimum fixé et le jour d'aujourd'hui
        {
            DateTime start = new DateTime(2012, 05, 25); // définie la date minimum

            int nbJoursHasard = ((TimeSpan)(DateTime.Today - start)).Days;
            return start.AddDays(rndNumbers.Next(nbJoursHasard));
        }

        public void simuBornesStations(decimal nbBornes)
        // Crée des bornes et affecte les bornes a une station aléatoirement (en les ajoutant a la liste de borne de cette station)
        {

            resetBornesVisitesBordesDesTechniciens();

            int nbAleatoire = 0; // Variable recevant le nombre aléatoire
            int nbTypes = lesTypesBornes.Count();
            int nbStation = this.LesStations.Count();
            int nbHasardS = 0;// Variable recevant le nombre aléatoire pr Station
            


            int i = 0;
            while (i < nbBornes)
            {
                nbAleatoire = rndNumbers.Next(200); // Un nombre aléatoire de 0 à 200;
                nbHasardS = rndNumbers.Next(nbStation);

                // On crée une borne avec un indice i, un nombre d'unité aléatoire, une date aléatoire, et un type aléatoire);
                Borne uneBorne = new Borne(i, nbAleatoire, DateAuHasard(), randomTypeBorne(lesTypesBornes));

                List<Borne> randomListeBorne = new List<Borne>();

                this.addBorne(uneBorne, nbHasardS);
                i++;
            }
        }

        private void resetBornesVisitesBordesDesTechniciens()
            // Pour créer une Nouvelle situation, on efface l'ancienne. On efface donc les bornes des stations, les stations elles meme et les visites affectées aux techniciens
        {
            int i = 0;
            
            while (i < lesStations.Count())
            {
                lesStations[i].LesBornes.Clear();
                i++;
            }

            foreach (Technicien unTechnicien in lesTechniciens)
            {
                unTechnicien.LesVisites.Clear();
            }

            lesVisites.Clear();
        }
        #endregion

        #endregion




    }
}
