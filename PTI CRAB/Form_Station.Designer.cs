namespace WindowsFormsApplication1
{
    partial class Form_Station
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
            this.lbx_stations = new System.Windows.Forms.ListBox();
            this.lbx_bornes = new System.Windows.Forms.ListBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_addBorne = new System.Windows.Forms.Button();
            this.btn_delBorne = new System.Windows.Forms.Button();
            this.txb_idStation = new System.Windows.Forms.TextBox();
            this.txb_emplacement = new System.Windows.Forms.TextBox();
            this.txb_idBorne = new System.Windows.Forms.TextBox();
            this.txb_indice = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_stations
            // 
            this.lbx_stations.FormattingEnabled = true;
            this.lbx_stations.Location = new System.Drawing.Point(12, 12);
            this.lbx_stations.Name = "lbx_stations";
            this.lbx_stations.Size = new System.Drawing.Size(285, 134);
            this.lbx_stations.TabIndex = 0;
            this.lbx_stations.SelectedIndexChanged += new System.EventHandler(this.lbx_stations_SelectedIndexChanged);
            // 
            // lbx_bornes
            // 
            this.lbx_bornes.FormattingEnabled = true;
            this.lbx_bornes.Location = new System.Drawing.Point(313, 12);
            this.lbx_bornes.Name = "lbx_bornes";
            this.lbx_bornes.Size = new System.Drawing.Size(290, 134);
            this.lbx_bornes.TabIndex = 1;
             // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(190, 69);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 2;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(222, 154);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_addBorne
            // 
            this.btn_addBorne.Location = new System.Drawing.Point(205, 126);
            this.btn_addBorne.Name = "btn_addBorne";
            this.btn_addBorne.Size = new System.Drawing.Size(75, 23);
            this.btn_addBorne.TabIndex = 4;
            this.btn_addBorne.Text = "Ajouter";
            this.btn_addBorne.UseVisualStyleBackColor = true;
            this.btn_addBorne.Click += new System.EventHandler(this.btn_addBorne_Click);
            // 
            // btn_delBorne
            // 
            this.btn_delBorne.Location = new System.Drawing.Point(528, 152);
            this.btn_delBorne.Name = "btn_delBorne";
            this.btn_delBorne.Size = new System.Drawing.Size(75, 23);
            this.btn_delBorne.TabIndex = 5;
            this.btn_delBorne.Text = "Supprimer";
            this.btn_delBorne.UseVisualStyleBackColor = true;
            this.btn_delBorne.Click += new System.EventHandler(this.btn_delBorne_Click);
            // 
            // txb_idStation
            // 
            this.txb_idStation.Location = new System.Drawing.Point(210, 22);
            this.txb_idStation.Name = "txb_idStation";
            this.txb_idStation.Size = new System.Drawing.Size(55, 20);
            this.txb_idStation.TabIndex = 6;
            // 
            // txb_emplacement
            // 
            this.txb_emplacement.Location = new System.Drawing.Point(132, 45);
            this.txb_emplacement.Name = "txb_emplacement";
            this.txb_emplacement.Size = new System.Drawing.Size(133, 20);
            this.txb_emplacement.TabIndex = 7;
            // 
            // txb_idBorne
            // 
            this.txb_idBorne.Location = new System.Drawing.Point(118, 37);
            this.txb_idBorne.Name = "txb_idBorne";
            this.txb_idBorne.Size = new System.Drawing.Size(53, 20);
            this.txb_idBorne.TabIndex = 8;
            // 
            // txb_indice
            // 
            this.txb_indice.Location = new System.Drawing.Point(226, 37);
            this.txb_indice.Name = "txb_indice";
            this.txb_indice.Size = new System.Drawing.Size(54, 20);
            this.txb_indice.TabIndex = 10;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(118, 63);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(162, 20);
            this.DatePicker.TabIndex = 12;
            // 
            // cbx_type
            // 
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Location = new System.Drawing.Point(118, 89);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(162, 21);
            this.cbx_type.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Emplacement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Id borne";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date dernière révision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Indice d\'unité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Type de borne";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_ajouter);
            this.groupBox1.Controls.Add(this.txb_emplacement);
            this.groupBox1.Controls.Add(this.txb_idStation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter station";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_type);
            this.groupBox2.Controls.Add(this.btn_addBorne);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txb_idBorne);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txb_indice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DatePicker);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(313, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 172);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ajouter borne";
            // 
            // Form_Station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delBorne);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.lbx_bornes);
            this.Controls.Add(this.lbx_stations);
            this.Name = "Form_Station";
            this.Text = "Form_Station";
            this.Load += new System.EventHandler(this.Form_Station_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_stations;
        private System.Windows.Forms.ListBox lbx_bornes;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_addBorne;
        private System.Windows.Forms.Button btn_delBorne;
        private System.Windows.Forms.TextBox txb_idStation;
        private System.Windows.Forms.TextBox txb_emplacement;
        private System.Windows.Forms.TextBox txb_idBorne;
        private System.Windows.Forms.TextBox txb_indice;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}