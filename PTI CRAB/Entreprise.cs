using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
   

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Maintenance CRAB;
        private string cheminFichier = "donnees.xml"; // Nom du fichier de la maintenance (ex : ile de france)

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime unedate = new DateTime(2012, 06, 1);
            List<TypeBorne> desTypes = new List<TypeBorne>(); ; 
            
            TypeBorne Type1 = new TypeBorne("NORM", 30, 30, 80);
            TypeBorne Type2 = new TypeBorne("SEMI", 45, 20, 100);
            TypeBorne Type3 = new TypeBorne("RAPI", 50, 15, 120);
            desTypes.Add(Type1);
            desTypes.Add(Type2);
            desTypes.Add(Type3);

            /*List<Borne> S1Bornes = new List<Borne>();
            List<Borne> S2Bornes = new List<Borne>();
            Borne S1B1 = new Borne(1, 20, Type2);
            Borne S1B2 = new Borne(2, 110, unedate, Type3);
            Borne S2B1 = new Borne(1, 85, Type1);
            Borne S2B2 = new Borne(2, 110, unedate, Type2);
            Borne S2B3 = new Borne(3, 20, Type2);
            S1Bornes.Add(S1B1);
            S1Bornes.Add(S1B2);
            S2Bornes.Add(S2B1);
            S2Bornes.Add(S2B2);*/

            List<Station> desStations = new List<Station>();
            Station S1 = new Station(1, "Gentilly");
            Station S2 = new Station(2, "Cachan");
            Station S3 = new Station(3, "Choisy");
            desStations.Add(S1);
            desStations.Add(S2);
            desStations.Add(S3);



            List<Technicien> desTechniciens = new List<Technicien>();
            Technicien T1 = new Technicien(1, "Legenty", "Geoffrey");
            Technicien T2 = new Technicien(2, "Amari", "Sofiane");
            Technicien T3 = new Technicien(3, "Magassa", "Nouhou");
            desTechniciens.Add(T1);
            desTechniciens.Add(T2);
            desTechniciens.Add(T3);    

            CRAB = new Maintenance(desStations, desTechniciens,desTypes);
            CRAB.GenereVisitesP();
            CRAB.lierVisites(lbx_visites,CRAB.LesVisites);
        }

        #region XML
        private void sauvegarde(string fileName)
        // Sauvegarde les données au format XML
        {
            Type[] extraTypes = new Type[4]; // Tableau de type
            extraTypes[0] = typeof(List<Station>);
            extraTypes[1] = typeof(List<Technicien>);
            extraTypes[2] = typeof(List<Visite>);
            extraTypes[3] = typeof(List<TypeBorne>);

            FileStream stream = new FileStream(fileName, FileMode.Create); // On crée un fichier et un flux pour écrire et lire les données
            XmlSerializer serializer = new XmlSerializer(CRAB.GetType(), extraTypes); // On crée un objet Serializer 

            serializer.Serialize(stream, CRAB); // On sérialise a partir du flux et de la liste de departements
            stream.Close(); // On ferme le flux
        }

        private void chargement(string fileName)
        // Charge les données à partir du fichier XML généré par la sauvegarde
        {
            if (File.Exists(fileName))
            {
                Type[] extraTypes = new Type[4]; // Tableau de type
                extraTypes[0] = typeof(List<Station>);
                extraTypes[1] = typeof(List<Technicien>);
                extraTypes[2] = typeof(List<Visite>);
                extraTypes[3] = typeof(List<TypeBorne>);

                XmlSerializer deserializer = new XmlSerializer(CRAB.GetType(), extraTypes);
                FileStream stream = new FileStream(fileName, FileMode.Open); // On ouvre un flux pour lire les données dans le fichier data.xml

                CRAB = (Maintenance)deserializer.Deserialize(stream);
                stream.Close();

            }
        }
        #endregion

        private void btn_tech_Click_1(object sender, EventArgs e)
        {
            Form_Tech Gestion_Tech = new Form_Tech(CRAB);            
            Gestion_Tech.ShowDialog();
            CRAB.lierVisites(lbx_visites, CRAB.LesVisites);
        }
       
        private void btn_affecter_Click(object sender, EventArgs e)
        {
            CRAB.affecterVisite();
            CRAB.lierVisites(lbx_visites, CRAB.LesVisites);
        }

        private void btn_details_Click(object sender, EventArgs e)
        {          

            int index = lbx_visites.SelectedIndex;
            if (index >= 0)
            {
                Visite selectedVisite = CRAB.LesVisites[index];
                Form_Visite Gestion_Visite = new Form_Visite(selectedVisite, CRAB);                
                Gestion_Visite.ShowDialog();  
                CRAB.lierVisites(lbx_visites, CRAB.LesVisites);
            }

        }

        private void btn_station_Click(object sender, EventArgs e)
        {
            Form_Station Gestion_Station = new Form_Station(CRAB);            

            Gestion_Station.ShowDialog();
            CRAB.lierVisites(lbx_visites, CRAB.LesVisites);
        }

        private void btn_simulation_Click(object sender, EventArgs e)
        {
            Form_Simulation Simu = new Form_Simulation(CRAB);
            Simu.ShowDialog();

            CRAB.lierVisites(lbx_visites, CRAB.LesVisites);
        } 

        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Affiche une boite de dialoge permettant à l'utilisateur de charger un fichier
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "CRAB Files|*.cr";
                openFileDialog1.Title = "Choissisez un fichier CRAB";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)  // On montre la boite de dialogue et si l'user met OK
                {
                    chargement(openFileDialog1.FileName);
                    MessageBox.Show("Chargement réussi.");
                    enregistrerToolStripMenuItem.Enabled = true; // On rend possible le fait d'enregistrer un fichier
                    
                    cheminFichier = openFileDialog1.FileName;
                    string fileNameCourt = openFileDialog1.FileName;
                 //   lb_fileName.Text = "Nom du fichier : " + fileNameCourt.Substring(fileNameCourt.LastIndexOf("\\") + 1); // Permet d'afficher le nom du fichier sans le chemin
                    CRAB.lierVisites(lbx_visites, CRAB.LesVisites);
                }
            }
            catch (IOException exFichier)
            {
                MessageBox.Show("Le fichier n'a pas pu être sauvegardé.");
            }
            //catch (Exception exGen)
            //{
            //    MessageBox.Show("Une erreur est survenu.");
            //}
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (cheminFichier != "") // on vérifie qu'un fichier est déjà ouvert
                {
                    sauvegarde(cheminFichier);
                    MessageBox.Show("Sauvegarde réussie.");
                }
                else
                    MessageBox.Show("Vous n'avez rien ouvert.");
            }
            catch (IOException exIO)
            {
                MessageBox.Show("Le fichier n'a pas pu être sauvegardé.");
            }

            //catch (Exception exGeneral)
            //{
            //    MessageBox.Show("Une erreur est survenue.");
            //}
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "CRAB Files|*.cr";
                saveFileDialog1.Title = "Enregistrer un fichier CRAB";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK) // On montre la boite de dialogue et si l'user met OK
                {
                    sauvegarde(saveFileDialog1.FileName);
                    MessageBox.Show("Sauvegarde réussi.");

                }
            }
            catch (IOException exFichier)
            {
                MessageBox.Show("Le fichie n'a pas pu être sauvegardé");
            }
            //catch (Exception exGen)
            //{
            //    MessageBox.Show("Une erreur est survenu.");
            //}
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





    }
}
