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
    public partial class Form_Visite : Form
    {
        public Form_Visite(Visite uneVisite, Maintenance uneM)
        {
            InitializeComponent();
            selectedVisite = uneVisite;
            maintenance1 = uneM;
        }
        private Maintenance maintenance1;
        /* CRAB Get & Set maintenance1*/
        public Maintenance CRAB
        {
            get { return maintenance1; }
            set { maintenance1 = value; }
        }
        private Visite selectedVisite;

        private void Form_Visite_Load(object sender, EventArgs e)
        {
            txb_idStation.Text = selectedVisite.LaStation.LibelleEmplacement;
            txb_duree.Text = Convert.ToString(selectedVisite.DureeTotale) + "mn";
            if (selectedVisite.Etat == "p")
            {
                rb_p.Checked = true;
                rb_p.ForeColor = Color.Red;
                rb_a.Enabled = false;
                rb_r.Enabled = false;
            }
            else
            {
                txb_tech.Visible = true;
                lbl_tech.Visible = true;
                txb_tech.Text = "ID : " + maintenance1.TechDelaVisite(selectedVisite).Matricule + "  |  " + maintenance1.TechDelaVisite(selectedVisite).Nom + " " + maintenance1.TechDelaVisite(selectedVisite).Prenom;
                rb_p.Enabled = false;
                rb_a.Checked = true;
                rb_a.ForeColor = Color.Red; ;
                rb_a.Enabled = true;
                rb_r.Enabled = true;
            }

            CRAB.lierBorneVisite(selectedVisite, lbx_bornes);
        }


        private void btn_valider_Click(object sender, EventArgs e)
        {

            if (rb_r.Checked == true)
                CRAB.realiserVisite(selectedVisite);
            this.Close();
        }
    }
}
