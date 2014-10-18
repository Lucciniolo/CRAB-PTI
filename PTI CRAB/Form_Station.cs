using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_Station : Form
    {
        public Form_Station(Maintenance uneM)
        {
            InitializeComponent();
            maintenance1 = uneM;
        }

        private Maintenance maintenance1;
        /* CRAB GET & SET de maintenace */
        public Maintenance CRAB
        {
            get { return maintenance1; }
            set { maintenance1 = value; }
        }

        private void Form_Station_Load(object sender, EventArgs e)
        {
            CRAB.lierStations(lbx_stations);
            cbx_type.DataSource = null;
            cbx_type.DataSource = CRAB.LesTypesBornes;            
            cbx_type.DisplayMember = "CodeTypeBorne";
           

        }

        private void lbx_stations_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbx_stations.SelectedIndex;
            if (index >= 0)
            {
                Station selectedStation = CRAB.LesStations[index];
                CRAB.lierBorneStation(selectedStation, lbx_bornes);
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Station newStation = new Station(Convert.ToInt32(txb_idStation.Text), txb_emplacement.Text);
                CRAB.addStation(newStation);
                CRAB.lierStations(lbx_stations);
                lbx_bornes.Items.Clear();
                txb_idStation.ResetText();
                txb_emplacement.ResetText();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Veuillez renseigner ces champs correctement");
            }
            catch (Exception exGeneral)
            {
                MessageBox.Show("Une erreur est survenue");
            }  
            
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbx_stations.SelectedIndex;
                Station selectedStation = CRAB.LesStations[index];
                CRAB.delStation(selectedStation);
                CRAB.lierStations(lbx_stations);
                lbx_bornes.Items.Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Veuillez selectionner une station");
            }
            catch (Exception exGeneral)
            {
                MessageBox.Show("Une erreur est survenue");
            }  
            
        }

        private void btn_addBorne_Click(object sender, EventArgs e)
        {
            int indexStation = lbx_stations.SelectedIndex;
            int indexBorne = lbx_bornes.SelectedIndex;
            if (indexStation >= 0)
            {
                try
                {
                    TypeBorne unType = (TypeBorne)cbx_type.SelectedItem;
                    Borne newBorne = new Borne(Convert.ToInt32(txb_idBorne.Text), Convert.ToInt32(txb_indice.Text), unType);
                    Station selectedStation = CRAB.LesStations[indexStation];
                    CRAB.addBorne(newBorne, indexStation);
                    CRAB.lierBorneStation(selectedStation, lbx_bornes);
                    txb_idBorne.ResetText();
                    txb_indice.ResetText();
                    DatePicker.ResetText();
                    CRAB.lierStations(lbx_stations);
                    cbx_type.SelectedItem = CRAB.LesTypesBornes[0];
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Veuillez renseigner ces champs correctement");
                }
                catch (Exception exGeneral)
                {
                    MessageBox.Show("Une erreur est survenue");
                }  
            }
            
        }

        private void btn_delBorne_Click(object sender, EventArgs e)
        {
            try
            {
                int indexStation = lbx_stations.SelectedIndex;
                int indexBorne = lbx_bornes.SelectedIndex;

                Borne selectedBorne = CRAB.LesStations[indexStation].LesBornes[indexBorne];
                Station selectedStation = CRAB.LesStations[indexStation];
                CRAB.delBorne(selectedBorne, indexStation);
                CRAB.lierStations(lbx_stations);
                CRAB.lierBorneStation(selectedStation, lbx_bornes);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Veillez selectionner une station et une borne pour effectuer une suppression");
            }
            catch (Exception exGeneral)
            {
                MessageBox.Show("Une erreur est survenue");
            }  

        }


    }
}
