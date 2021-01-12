namespace Gestion
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gEncodage = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tnbProduit = new System.Windows.Forms.NumericUpDown();
            this.tPrixProduit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.dtProduit = new System.Windows.Forms.DateTimePicker();
            this.tNomProduit = new System.Windows.Forms.TextBox();
            this.gEncodage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tnbProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // gEncodage
            // 
            this.gEncodage.BackColor = System.Drawing.Color.Honeydew;
            this.gEncodage.Controls.Add(this.label5);
            this.gEncodage.Controls.Add(this.tnbProduit);
            this.gEncodage.Controls.Add(this.tPrixProduit);
            this.gEncodage.Controls.Add(this.label4);
            this.gEncodage.Controls.Add(this.label3);
            this.gEncodage.Controls.Add(this.label2);
            this.gEncodage.Controls.Add(this.label1);
            this.gEncodage.Controls.Add(this.bSubmit);
            this.gEncodage.Controls.Add(this.dtProduit);
            this.gEncodage.Controls.Add(this.tNomProduit);
            this.gEncodage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gEncodage.Location = new System.Drawing.Point(36, 39);
            this.gEncodage.Name = "gEncodage";
            this.gEncodage.Size = new System.Drawing.Size(645, 377);
            this.gEncodage.TabIndex = 0;
            this.gEncodage.TabStop = false;
            this.gEncodage.Text = "ENCODAGE DES PRODUITS";
            this.gEncodage.Enter += new System.EventHandler(this.gEncodage_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "    €";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tnbProduit
            // 
            this.tnbProduit.Location = new System.Drawing.Point(222, 223);
            this.tnbProduit.Name = "tnbProduit";
            this.tnbProduit.Size = new System.Drawing.Size(120, 22);
            this.tnbProduit.TabIndex = 10;
            // 
            // tPrixProduit
            // 
            this.tPrixProduit.Location = new System.Drawing.Point(222, 102);
            this.tPrixProduit.Name = "tPrixProduit";
            this.tPrixProduit.Size = new System.Drawing.Size(100, 22);
            this.tPrixProduit.TabIndex = 9;
            this.tPrixProduit.TextChanged += new System.EventHandler(this.tPrixProduit_TextChanged);
            this.tPrixProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPrixProduit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(31, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre de Produit/unité :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(31, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date d\'entrée :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prix du Produit :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom du Produit :";
            // 
            // bSubmit
            // 
            this.bSubmit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bSubmit.Location = new System.Drawing.Point(289, 306);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(89, 38);
            this.bSubmit.TabIndex = 4;
            this.bSubmit.Text = "Enrégistrer";
            this.bSubmit.UseVisualStyleBackColor = false;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // dtProduit
            // 
            this.dtProduit.Location = new System.Drawing.Point(222, 165);
            this.dtProduit.Name = "dtProduit";
            this.dtProduit.Size = new System.Drawing.Size(227, 22);
            this.dtProduit.TabIndex = 2;
            // 
            // tNomProduit
            // 
            this.tNomProduit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tNomProduit.Location = new System.Drawing.Point(222, 46);
            this.tNomProduit.Name = "tNomProduit";
            this.tNomProduit.Size = new System.Drawing.Size(227, 22);
            this.tNomProduit.TabIndex = 0;
            this.tNomProduit.TextChanged += new System.EventHandler(this.tNomProduit_TextChanged);
            this.tNomProduit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tNomProduit_KeyDown);
            this.tNomProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNomProduit_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gEncodage);
            this.Name = "Form2";
            this.Text = "ENCODAGE ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gEncodage.ResumeLayout(false);
            this.gEncodage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tnbProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gEncodage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.DateTimePicker dtProduit;
        private System.Windows.Forms.TextBox tNomProduit;
        private System.Windows.Forms.TextBox tPrixProduit;
        private System.Windows.Forms.NumericUpDown tnbProduit;
        private System.Windows.Forms.Label label5;
    }
}