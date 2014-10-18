namespace WindowsFormsApplication1
{
    partial class Form_Simulation
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
            this.btn_simuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbn_bornes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txbn_bornes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_simuler
            // 
            this.btn_simuler.Location = new System.Drawing.Point(59, 39);
            this.btn_simuler.Name = "btn_simuler";
            this.btn_simuler.Size = new System.Drawing.Size(75, 23);
            this.btn_simuler.TabIndex = 8;
            this.btn_simuler.Text = "Generer";
            this.btn_simuler.UseVisualStyleBackColor = true;
            this.btn_simuler.Click += new System.EventHandler(this.btn_simuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de bornes :";
            // 
            // txbn_bornes
            // 
            this.txbn_bornes.Location = new System.Drawing.Point(118, 8);
            this.txbn_bornes.Name = "txbn_bornes";
            this.txbn_bornes.Size = new System.Drawing.Size(56, 20);
            this.txbn_bornes.TabIndex = 6;
            // 
            // Form_Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 72);
            this.Controls.Add(this.btn_simuler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbn_bornes);
            this.Name = "Form_Simulation";
            this.Text = "Form_Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.txbn_bornes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_simuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txbn_bornes;
    }
}