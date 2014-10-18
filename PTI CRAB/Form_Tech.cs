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
    public partial class Form_Tech : Form
    {
        public Form_Tech(Maintenance uneM)
        {
            InitializeComponent();
            maintenance1 = uneM;
        }
        private Maintenance maintenance1;
        /* CRAB Get & Set de maintenance1 */
        public Maintenance CRAB
        {
            get { return maintenance1; }
            set { maintenance1 = value; }
        }


        private void Form_Tech_Load(object sender, EventArgs e)
        {
            CRAB.lierTechniciens(lbx_tech);
        }     
        private void lbx_tech_SelectedIndexChanged(object sender, EventArgs e)
        {
             int index = lbx_tech.SelectedIndex;
             if (index >= 0)
            {      
                Technicien selectedTech = CRAB.LesTechniciens[lbx_tech.SelectedIndex];
                CRAB.lierVisitesTech(selectedTech, lbx_visites);
            }  
          
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

            try
            {
                Technicien newTech = new Technicien(Convert.ToInt32(txb_matricule.Text), txb_nom.Text, txb_prenom.Text);
                CRAB.addTech(newTech);
                CRAB.lierTechniciens(lbx_tech);
                txb_prenom.ResetText();
                txb_nom.ResetText();
                txb_matricule.ResetText();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(" Veuillez renseigner ces champs correctement");
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
                Technicien selectedTech = CRAB.LesTechniciens[lbx_tech.SelectedIndex];
                CRAB.delTech(selectedTech);
                lbx_visites.Items.Clear();
                CRAB.lierTechniciens(lbx_tech); // Permet de rafraichir la liste des techniciens
            }
            catch (ArgumentOutOfRangeException Aex)
            {
                MessageBox.Show(" Veuillez selectionner un technicien ");
            }
            catch (Exception exGeneral)
            {
                MessageBox.Show("Une erreur est survenue");
            }  

        }             

    }
}
