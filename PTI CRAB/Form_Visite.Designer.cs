namespace WindowsFormsApplication1
{
    partial class Form_Visite
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
            this.txb_idStation = new System.Windows.Forms.TextBox();
            this.txb_duree = new System.Windows.Forms.TextBox();
            this.lbx_bornes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Station = new System.Windows.Forms.GroupBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_tech = new System.Windows.Forms.TextBox();
            this.lbl_tech = new System.Windows.Forms.Label();
            this.rb_p = new System.Windows.Forms.RadioButton();
            this.rb_r = new System.Windows.Forms.RadioButton();
            this.rb_a = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Station.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_idStation
            // 
            this.txb_idStation.Enabled = false;
            this.txb_idStation.Location = new System.Drawing.Point(52, 19);
            this.txb_idStation.Name = "txb_idStation";
            this.txb_idStation.Size = new System.Drawing.Size(151, 20);
            this.txb_idStation.TabIndex = 0;
            // 
            // txb_duree
            // 
            this.txb_duree.Enabled = false;
            this.txb_duree.Location = new System.Drawing.Point(52, 19);
            this.txb_duree.Name = "txb_duree";
            this.txb_duree.Size = new System.Drawing.Size(151, 20);
            this.txb_duree.TabIndex = 1;
            // 
            // lbx_bornes
            // 
            this.lbx_bornes.FormattingEnabled = true;
            this.lbx_bornes.Location = new System.Drawing.Point(6, 19);
            this.lbx_bornes.Name = "lbx_bornes";
            this.lbx_bornes.Size = new System.Drawing.Size(239, 69);
            this.lbx_bornes.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_duree);
            this.groupBox2.Location = new System.Drawing.Point(17, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 56);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durée";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbx_bornes);
            this.groupBox3.Location = new System.Drawing.Point(17, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bornes";
            // 
            // Station
            // 
            this.Station.Controls.Add(this.txb_idStation);
            this.Station.Location = new System.Drawing.Point(17, 7);
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(251, 45);
            this.Station.TabIndex = 9;
            this.Station.TabStop = false;
            this.Station.Text = "Station";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(102, 332);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 10;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_tech);
            this.groupBox1.Controls.Add(this.lbl_tech);
            this.groupBox1.Controls.Add(this.rb_p);
            this.groupBox1.Controls.Add(this.rb_r);
            this.groupBox1.Controls.Add(this.rb_a);
            this.groupBox1.Location = new System.Drawing.Point(17, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etat";
            // 
            // txb_tech
            // 
            this.txb_tech.Enabled = false;
            this.txb_tech.Location = new System.Drawing.Point(50, 61);
            this.txb_tech.Name = "txb_tech";
            this.txb_tech.Size = new System.Drawing.Size(160, 20);
            this.txb_tech.TabIndex = 7;
            this.txb_tech.Visible = false;
            // 
            // lbl_tech
            // 
            this.lbl_tech.AutoSize = true;
            this.lbl_tech.Location = new System.Drawing.Point(101, 45);
            this.lbl_tech.Name = "lbl_tech";
            this.lbl_tech.Size = new System.Drawing.Size(60, 13);
            this.lbl_tech.TabIndex = 6;
            this.lbl_tech.Text = "Technicien";
            this.lbl_tech.Visible = false;
            // 
            // rb_p
            // 
            this.rb_p.AutoSize = true;
            this.rb_p.Location = new System.Drawing.Point(6, 19);
            this.rb_p.Name = "rb_p";
            this.rb_p.Size = new System.Drawing.Size(84, 17);
            this.rb_p.TabIndex = 3;
            this.rb_p.TabStop = true;
            this.rb_p.Text = "Programmée";
            this.rb_p.UseVisualStyleBackColor = true;
            // 
            // rb_r
            // 
            this.rb_r.AutoSize = true;
            this.rb_r.Location = new System.Drawing.Point(179, 19);
            this.rb_r.Name = "rb_r";
            this.rb_r.Size = new System.Drawing.Size(66, 17);
            this.rb_r.TabIndex = 5;
            this.rb_r.TabStop = true;
            this.rb_r.Text = "Réalisée";
            this.rb_r.UseVisualStyleBackColor = true;
            // 
            // rb_a
            // 
            this.rb_a.AutoSize = true;
            this.rb_a.Location = new System.Drawing.Point(95, 19);
            this.rb_a.Name = "rb_a";
            this.rb_a.Size = new System.Drawing.Size(65, 17);
            this.rb_a.TabIndex = 4;
            this.rb_a.TabStop = true;
            this.rb_a.Text = "Affectée";
            this.rb_a.UseVisualStyleBackColor = true;
            // 
            // Form_Visite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.Station);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form_Visite";
            this.Text = "Form_Visite";
            this.Load += new System.EventHandler(this.Form_Visite_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.Station.ResumeLayout(false);
            this.Station.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txb_idStation;
        private System.Windows.Forms.TextBox txb_duree;
        private System.Windows.Forms.ListBox lbx_bornes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox Station;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_tech;
        private System.Windows.Forms.Label lbl_tech;
        private System.Windows.Forms.RadioButton rb_p;
        private System.Windows.Forms.RadioButton rb_r;
        private System.Windows.Forms.RadioButton rb_a;
    }
}