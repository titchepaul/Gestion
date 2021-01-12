namespace Gestion
{
    partial class Ventes
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
            this.lbVentes = new System.Windows.Forms.Label();
            this.cbVentes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrixProduit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtVentes = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btSaveVentes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nUpDownQuantite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVentes
            // 
            this.lbVentes.AutoSize = true;
            this.lbVentes.Location = new System.Drawing.Point(142, 66);
            this.lbVentes.Name = "lbVentes";
            this.lbVentes.Size = new System.Drawing.Size(114, 17);
            this.lbVentes.TabIndex = 0;
            this.lbVentes.Text = "Nom du Produit :";
            // 
            // cbVentes
            // 
            this.cbVentes.FormattingEnabled = true;
            this.cbVentes.Location = new System.Drawing.Point(319, 66);
            this.cbVentes.Name = "cbVentes";
            this.cbVentes.Size = new System.Drawing.Size(200, 24);
            this.cbVentes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prix du Produit :";
            // 
            // tbPrixProduit
            // 
            this.tbPrixProduit.Location = new System.Drawing.Point(319, 127);
            this.tbPrixProduit.Name = "tbPrixProduit";
            this.tbPrixProduit.Size = new System.Drawing.Size(98, 22);
            this.tbPrixProduit.TabIndex = 3;
            this.tbPrixProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrixProduit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date de vente : ";
            // 
            // dtVentes
            // 
            this.dtVentes.Location = new System.Drawing.Point(319, 187);
            this.dtVentes.Name = "dtVentes";
            this.dtVentes.Size = new System.Drawing.Size(230, 22);
            this.dtVentes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantité de pièce(s) :";
            // 
            // btSaveVentes
            // 
            this.btSaveVentes.Location = new System.Drawing.Point(293, 341);
            this.btSaveVentes.Name = "btSaveVentes";
            this.btSaveVentes.Size = new System.Drawing.Size(126, 47);
            this.btSaveVentes.TabIndex = 8;
            this.btSaveVentes.Text = "Enrégistrer";
            this.btSaveVentes.UseVisualStyleBackColor = true;
            this.btSaveVentes.Click += new System.EventHandler(this.btSaveVentes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ENCODAGE DES VENTES";
            // 
            // nUpDownQuantite
            // 
            this.nUpDownQuantite.Location = new System.Drawing.Point(322, 253);
            this.nUpDownQuantite.Name = "nUpDownQuantite";
            this.nUpDownQuantite.Size = new System.Drawing.Size(120, 22);
            this.nUpDownQuantite.TabIndex = 10;
            // 
            // Ventes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion.Properties.Resources.aloe_vera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nUpDownQuantite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSaveVentes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtVentes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrixProduit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVentes);
            this.Controls.Add(this.lbVentes);
            this.Name = "Ventes";
            this.Text = "Ventes";
            this.Load += new System.EventHandler(this.Ventes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVentes;
        private System.Windows.Forms.ComboBox cbVentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrixProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtVentes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSaveVentes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUpDownQuantite;
    }
}