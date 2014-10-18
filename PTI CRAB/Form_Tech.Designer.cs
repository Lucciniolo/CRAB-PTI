namespace WindowsFormsApplication1
{
    partial class Form_Tech
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_visites = new System.Windows.Forms.ListBox();
            this.Visites = new System.Windows.Forms.GroupBox();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.lbx_tech = new System.Windows.Forms.ListBox();
            this.Techniciens = new System.Windows.Forms.GroupBox();
            this.gbx_ajout = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_nom = new System.Windows.Forms.TextBox();
            this.txb_matricule = new System.Windows.Forms.TextBox();
            this.txb_prenom = new System.Windows.Forms.TextBox();
            this.Visites.SuspendLayout();
            this.Techniciens.SuspendLayout();
            this.gbx_ajout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_visites
            // 
            this.lbx_visites.FormattingEnabled = true;
            this.lbx_visites.Location = new System.Drawing.Point(7, 24);
            this.lbx_visites.Name = "lbx_visites";
            this.lbx_visites.Size = new System.Drawing.Size(291, 303);
            this.lbx_visites.TabIndex = 4;
            // 
            // Visites
            // 
            this.Visites.Controls.Add(this.lbx_visites);
            this.Visites.Location = new System.Drawing.Point(313, 12);
            this.Visites.Name = "Visites";
            this.Visites.Size = new System.Drawing.Size(304, 333);
            this.Visites.TabIndex = 5;
            this.Visites.TabStop = false;
            this.Visites.Text = "Visites";
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(206, 179);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(194, 67);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 2;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // lbx_tech
            // 
            this.lbx_tech.FormattingEnabled = true;
            this.lbx_tech.Location = new System.Drawing.Point(12, 26);
            this.lbx_tech.Name = "lbx_tech";
            this.lbx_tech.Size = new System.Drawing.Size(269, 147);
            this.lbx_tech.TabIndex = 0;
            this.lbx_tech.SelectedIndexChanged += new System.EventHandler(this.lbx_tech_SelectedIndexChanged);
            // 
            // Techniciens
            // 
            this.Techniciens.Controls.Add(this.gbx_ajout);
            this.Techniciens.Controls.Add(this.btn_supprimer);
            this.Techniciens.Controls.Add(this.lbx_tech);
            this.Techniciens.Location = new System.Drawing.Point(12, 12);
            this.Techniciens.Name = "Techniciens";
            this.Techniciens.Size = new System.Drawing.Size(295, 333);
            this.Techniciens.TabIndex = 4;
            this.Techniciens.TabStop = false;
            this.Techniciens.Text = "Techniciens";
            // 
            // gbx_ajout
            // 
            this.gbx_ajout.Controls.Add(this.label3);
            this.gbx_ajout.Controls.Add(this.label2);
            this.gbx_ajout.Controls.Add(this.label1);
            this.gbx_ajout.Controls.Add(this.txb_nom);
            this.gbx_ajout.Controls.Add(this.txb_matricule);
            this.gbx_ajout.Controls.Add(this.txb_prenom);
            this.gbx_ajout.Controls.Add(this.btn_ajouter);
            this.gbx_ajout.Location = new System.Drawing.Point(6, 208);
            this.gbx_ajout.Name = "gbx_ajout";
            this.gbx_ajout.Size = new System.Drawing.Size(275, 98);
            this.gbx_ajout.TabIndex = 10;
            this.gbx_ajout.TabStop = false;
            this.gbx_ajout.Text = "Ajouter un technicien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Matricule";
            // 
            // txb_nom
            // 
            this.txb_nom.Location = new System.Drawing.Point(72, 43);
            this.txb_nom.Name = "txb_nom";
            this.txb_nom.Size = new System.Drawing.Size(100, 20);
            this.txb_nom.TabIndex = 6;
            // 
            // txb_matricule
            // 
            this.txb_matricule.Location = new System.Drawing.Point(117, 17);
            this.txb_matricule.Name = "txb_matricule";
            this.txb_matricule.Size = new System.Drawing.Size(55, 20);
            this.txb_matricule.TabIndex = 5;
            // 
            // txb_prenom
            // 
            this.txb_prenom.Location = new System.Drawing.Point(72, 69);
            this.txb_prenom.Name = "txb_prenom";
            this.txb_prenom.Size = new System.Drawing.Size(100, 20);
            this.txb_prenom.TabIndex = 4;
            // 
            // Form_Tech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 363);
            this.Controls.Add(this.Visites);
            this.Controls.Add(this.Techniciens);
            this.Name = "Form_Tech";
            this.Text = "Form_Tech";
            this.Load += new System.EventHandler(this.Form_Tech_Load);
            this.Visites.ResumeLayout(false);
            this.Techniciens.ResumeLayout(false);
            this.gbx_ajout.ResumeLayout(false);
            this.gbx_ajout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_visites;
        private System.Windows.Forms.GroupBox Visites;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.ListBox lbx_tech;
        private System.Windows.Forms.GroupBox Techniciens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_nom;
        private System.Windows.Forms.TextBox txb_matricule;
        private System.Windows.Forms.TextBox txb_prenom;
        private System.Windows.Forms.GroupBox gbx_ajout;
    }
}