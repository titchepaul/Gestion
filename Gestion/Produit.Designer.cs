namespace Gestion
{
    partial class Produit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomProd = new System.Windows.Forms.TextBox();
            this.tbPrixProd = new System.Windows.Forms.TextBox();
            this.tbNombreProd = new System.Windows.Forms.TextBox();
            this.dtpProd = new System.Windows.Forms.DateTimePicker();
            this.btSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEnterDate = new System.Windows.Forms.TextBox();
            this.cbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du Produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix du Produit :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date d\'entrée : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre de Produit/unité : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbNomProd
            // 
            this.tbNomProd.Location = new System.Drawing.Point(360, 87);
            this.tbNomProd.Name = "tbNomProd";
            this.tbNomProd.Size = new System.Drawing.Size(156, 22);
            this.tbNomProd.TabIndex = 4;
            this.tbNomProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomProd_KeyDown);
            this.tbNomProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomProd_KeyPress);
            // 
            // tbPrixProd
            // 
            this.tbPrixProd.Location = new System.Drawing.Point(360, 143);
            this.tbPrixProd.Name = "tbPrixProd";
            this.tbPrixProd.Size = new System.Drawing.Size(81, 22);
            this.tbPrixProd.TabIndex = 5;
            this.tbPrixProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrixProd_KeyPress);
            // 
            // tbNombreProd
            // 
            this.tbNombreProd.Location = new System.Drawing.Point(402, 311);
            this.tbNombreProd.Name = "tbNombreProd";
            this.tbNombreProd.Size = new System.Drawing.Size(80, 22);
            this.tbNombreProd.TabIndex = 6;
            this.tbNombreProd.TextChanged += new System.EventHandler(this.tbNombreProd_TextChanged);
            this.tbNombreProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreProd_KeyPress);
            // 
            // dtpProd
            // 
            this.dtpProd.Location = new System.Drawing.Point(360, 251);
            this.dtpProd.Name = "dtpProd";
            this.dtpProd.Size = new System.Drawing.Size(213, 22);
            this.dtpProd.TabIndex = 7;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(320, 400);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(102, 37);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Enrégistrer";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Veuillez encoder les champs à modifier svp :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "    €";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date de MAJ :";
            // 
            // tbEnterDate
            // 
            this.tbEnterDate.Location = new System.Drawing.Point(360, 200);
            this.tbEnterDate.Name = "tbEnterDate";
            this.tbEnterDate.Size = new System.Drawing.Size(122, 22);
            this.tbEnterDate.TabIndex = 12;
            // 
            // cbox
            // 
            this.cbox.AutoSize = true;
            this.cbox.Location = new System.Drawing.Point(331, 257);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(18, 17);
            this.cbox.TabIndex = 13;
            this.cbox.UseVisualStyleBackColor = true;
            this.cbox.CheckedChanged += new System.EventHandler(this.cbox_CheckedChanged);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion.Properties.Resources.aloe_vera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.tbEnterDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dtpProd);
            this.Controls.Add(this.tbNombreProd);
            this.Controls.Add(this.tbPrixProd);
            this.Controls.Add(this.tbNomProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Produit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomProd;
        private System.Windows.Forms.TextBox tbPrixProd;
        private System.Windows.Forms.TextBox tbNombreProd;
        private System.Windows.Forms.DateTimePicker dtpProd;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEnterDate;
        private System.Windows.Forms.CheckBox cbox;
    }
}