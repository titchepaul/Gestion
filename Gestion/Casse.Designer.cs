﻿namespace Gestion
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
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbCasse = new System.Windows.Forms.ComboBox();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.cbNomProduit.Location = new System.Drawing.Point(210, 79);
            this.cbNomProduit.Name = "cbNomProduit";
            this.cbNomProduit.Size = new System.Drawing.Size(121, 24);
            this.cbNomProduit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom Du Produit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date :";
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(210, 130);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(239, 22);
            this.dtPicker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prix Du Produit :";
            // 
            // tbPrixProduit
            // 
            this.tbPrixProduit.Location = new System.Drawing.Point(210, 188);
            this.tbPrixProduit.Name = "tbPrixProduit";
            this.tbPrixProduit.Size = new System.Drawing.Size(121, 22);
            this.tbPrixProduit.TabIndex = 6;
            this.tbPrixProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrixProduit_KeyPress);
            // 
            // nbcasse
            // 
            this.nbcasse.AutoSize = true;
            this.nbcasse.Location = new System.Drawing.Point(51, 236);
            this.nbcasse.Name = "nbcasse";
            this.nbcasse.Size = new System.Drawing.Size(127, 17);
            this.nbcasse.TabIndex = 7;
            this.nbcasse.Text = "Nbre(s) de Casse :";
            // 
            // nbreCasse
            // 
            this.nbreCasse.Location = new System.Drawing.Point(210, 231);
            this.nbreCasse.Name = "nbreCasse";
            this.nbreCasse.Size = new System.Drawing.Size(120, 22);
            this.nbreCasse.TabIndex = 8;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(195, 318);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(125, 51);
            this.btSave.TabIndex = 9;
            this.btSave.Text = "Enrégistrer";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(601, 79);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(164, 21);
            this.cbDelete.TabIndex = 10;
            this.cbDelete.Text = "Supprimer une casse";
            this.cbDelete.UseVisualStyleBackColor = true;
            this.cbDelete.CheckedChanged += new System.EventHandler(this.cbDelete_CheckedChanged);
            // 
            // cbCasse
            // 
            this.cbCasse.FormattingEnabled = true;
            this.cbCasse.Location = new System.Drawing.Point(612, 144);
            this.cbCasse.Name = "cbCasse";
            this.cbCasse.Size = new System.Drawing.Size(121, 24);
            this.cbCasse.TabIndex = 11;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(612, 236);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(109, 44);
            this.btSupprimer.TabIndex = 12;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "LISTE DES ARTICLES CASSÉ(S)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Casse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion.Properties.Resources.aloe_vera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.cbCasse);
            this.Controls.Add(this.cbDelete);
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
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.ComboBox cbCasse;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button button1;
    }
}