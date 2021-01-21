namespace Gestion
{
    partial class Casse
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbNomProduit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrixProduit = new System.Windows.Forms.TextBox();
            this.nbcasse = new System.Windows.Forms.Label();
            this.nbreCasse = new System.Windows.Forms.NumericUpDown();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbreCasse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTE DES PRODUITS CASSÉS";
            // 
            // cbNomProduit
            // 
            this.cbNomProduit.FormattingEnabled = true;
            this.cbNomProduit.Location = new System.Drawing.Point(291, 79);
            this.cbNomProduit.Name = "cbNomProduit";
            this.cbNomProduit.Size = new System.Drawing.Size(121, 24);
            this.cbNomProduit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom Du Produit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date :";
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(291, 130);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(239, 22);
            this.dtPicker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prix Du Produit :";
            // 
            // tbPrixProduit
            // 
            this.tbPrixProduit.Location = new System.Drawing.Point(291, 185);
            this.tbPrixProduit.Name = "tbPrixProduit";
            this.tbPrixProduit.Size = new System.Drawing.Size(121, 22);
            this.tbPrixProduit.TabIndex = 6;
            this.tbPrixProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrixProduit_KeyPress);
            // 
            // nbcasse
            // 
            this.nbcasse.AutoSize = true;
            this.nbcasse.Location = new System.Drawing.Point(146, 242);
            this.nbcasse.Name = "nbcasse";
            this.nbcasse.Size = new System.Drawing.Size(127, 17);
            this.nbcasse.TabIndex = 7;
            this.nbcasse.Text = "Nbre(s) de Casse :";
            // 
            // nbreCasse
            // 
            this.nbreCasse.Location = new System.Drawing.Point(291, 236);
            this.nbreCasse.Name = "nbreCasse";
            this.nbreCasse.Size = new System.Drawing.Size(120, 22);
            this.nbreCasse.TabIndex = 8;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(291, 326);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 41);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "Enrégistrer";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Casse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion.Properties.Resources.aloe_vera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.nbreCasse);
            this.Controls.Add(this.nbcasse);
            this.Controls.Add(this.tbPrixProduit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNomProduit);
            this.Controls.Add(this.label1);
            this.Name = "Casse";
            this.Text = "Casse";
            this.Load += new System.EventHandler(this.Casse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbreCasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNomProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrixProduit;
        private System.Windows.Forms.Label nbcasse;
        private System.Windows.Forms.NumericUpDown nbreCasse;
        private System.Windows.Forms.Button btSave;
    }
}