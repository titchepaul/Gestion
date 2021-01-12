namespace Gestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAffichageVentes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bEncodage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btVentes = new System.Windows.Forms.Button();
            this.btClients = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.btAffichageVentes);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(35, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 349);
            this.panel1.TabIndex = 0;
            // 
            // btAffichageVentes
            // 
            this.btAffichageVentes.Location = new System.Drawing.Point(696, 207);
            this.btAffichageVentes.Name = "btAffichageVentes";
            this.btAffichageVentes.Size = new System.Drawing.Size(133, 60);
            this.btAffichageVentes.TabIndex = 2;
            this.btAffichageVentes.Text = "ARTICLE(S) VENDU(S)";
            this.btAffichageVentes.UseVisualStyleBackColor = true;
            this.btAffichageVentes.Click += new System.EventHandler(this.btAffichageVentes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(696, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "MISE À JOUR DU PRODUIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(18, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(614, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // bEncodage
            // 
            this.bEncodage.Location = new System.Drawing.Point(92, 23);
            this.bEncodage.Name = "bEncodage";
            this.bEncodage.Size = new System.Drawing.Size(145, 47);
            this.bEncodage.TabIndex = 1;
            this.bEncodage.Text = "ENCODAGE DES PRODUITS";
            this.bEncodage.UseVisualStyleBackColor = true;
            this.bEncodage.Click += new System.EventHandler(this.bEncodage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "--  STOCK INITIAL DU PRODUIT  --";
            // 
            // btVentes
            // 
            this.btVentes.Location = new System.Drawing.Point(273, 23);
            this.btVentes.Name = "btVentes";
            this.btVentes.Size = new System.Drawing.Size(122, 47);
            this.btVentes.TabIndex = 3;
            this.btVentes.Text = "ENCODAGE DES VENTES";
            this.btVentes.UseVisualStyleBackColor = true;
            this.btVentes.Click += new System.EventHandler(this.btVentes_Click);
            // 
            // btClients
            // 
            this.btClients.Location = new System.Drawing.Point(467, 24);
            this.btClients.Name = "btClients";
            this.btClients.Size = new System.Drawing.Size(109, 46);
            this.btClients.TabIndex = 4;
            this.btClients.Text = "Clients";
            this.btClients.UseVisualStyleBackColor = true;
            this.btClients.Click += new System.EventHandler(this.btClients_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 529);
            this.Controls.Add(this.btClients);
            this.Controls.Add(this.btVentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEncodage);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bEncodage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAffichageVentes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVentes;
        private System.Windows.Forms.Button btClients;
    }
}

