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
    public partial class Form_Simulation : Form
    {
        public Form_Simulation(Maintenance uneM)
        {
            InitializeComponent();
            maintenance1 = uneM;
        }

        private Maintenance maintenance1;
        public Maintenance CRAB
        {
            get { return maintenance1; }
            set { maintenance1 = value; }
        }

        private void btn_simuler_Click(object sender, EventArgs e)
        {
            maintenance1.simuBornesStations(Convert.ToDecimal(txbn_bornes.Value));
            maintenance1.GenereVisitesP();
            this.Close();
        }
    }
}
