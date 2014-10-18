namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_tech = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_affecter = new System.Windows.Forms.Button();
            this.btn_details = new System.Windows.Forms.Button();
            this.lbx_visites = new System.Windows.Forms.ListBox();
            this.btn_station = new System.Windows.Forms.Button();
            this.btn_simulation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIchierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_tech
            // 
            this.btn_tech.Location = new System.Drawing.Point(429, 41);
            this.btn_tech.Name = "btn_tech";
            this.btn_tech.Size = new System.Drawing.Size(126, 43);
            this.btn_tech.TabIndex = 5;
            this.btn_tech.Text = "Techniciens";
            this.btn_tech.UseVisualStyleBackColor = true;
            this.btn_tech.Click += new System.EventHandler(this.btn_tech_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_affecter);
            this.groupBox2.Controls.Add(this.btn_details);
            this.groupBox2.Controls.Add(this.lbx_visites);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 279);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les visites";
            // 
            // btn_affecter
            // 
            this.btn_affecter.Location = new System.Drawing.Point(88, 235);
            this.btn_affecter.Name = "btn_affecter";
            this.btn_affecter.Size = new System.Drawing.Size(90, 34);
            this.btn_affecter.TabIndex = 10;
            this.btn_affecter.Text = "Affecter toutes les visites";
            this.btn_affecter.UseVisualStyleBackColor = true;
            this.btn_affecter.Click += new System.EventHandler(this.btn_affecter_Click);
            // 
            // btn_details
            // 
            this.btn_details.Location = new System.Drawing.Point(184, 235);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(91, 34);
            this.btn_details.TabIndex = 6;
            this.btn_details.Text = "Completer";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // lbx_visites
            // 
            this.lbx_visites.FormattingEnabled = true;
            this.lbx_visites.Location = new System.Drawing.Point(6, 40);
            this.lbx_visites.Name = "lbx_visites";
            this.lbx_visites.Size = new System.Drawing.Size(337, 186);
            this.lbx_visites.TabIndex = 0;
            // 
            // btn_station
            // 
            this.btn_station.Location = new System.Drawing.Point(429, 157);
            this.btn_station.Name = "btn_station";
            this.btn_station.Size = new System.Drawing.Size(126, 43);
            this.btn_station.TabIndex = 6;
            this.btn_station.Text = "Station";
            this.btn_station.UseVisualStyleBackColor = true;
            this.btn_station.Click += new System.EventHandler(this.btn_station_Click);
            // 
            // btn_simulation
            // 
            this.btn_simulation.Location = new System.Drawing.Point(429, 267);
            this.btn_simulation.Name = "btn_simulation";
            this.btn_simulation.Size = new System.Drawing.Size(126, 43);
            this.btn_simulation.TabIndex = 9;
            this.btn_simulation.Text = "Simulation";
            this.btn_simulation.UseVisualStyleBackColor = true;
            this.btn_simulation.Click += new System.EventHandler(this.btn_simulation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ces stations nécessitent une révision : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIchierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIchierToolStripMenuItem
            // 
            this.fIchierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.sauvegarderToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fIchierToolStripMenuItem.Name = "fIchierToolStripMenuItem";
            this.fIchierToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fIchierToolStripMenuItem.Text = "Fichier";
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.chargerToolStripMenuItem.Text = "Charger";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Enabled = false;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sauvegarderToolStripMenuItem.Text = "Enregistrer sous";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 332);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_simulation);
            this.Controls.Add(this.btn_tech);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_station);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tech;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.ListBox lbx_visites;
        private System.Windows.Forms.Button btn_station;
        private System.Windows.Forms.Button btn_affecter;
        private System.Windows.Forms.Button btn_simulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIchierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

