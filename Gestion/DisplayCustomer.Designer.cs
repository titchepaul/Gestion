namespace Gestion
{
    partial class DisplayCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbClient = new System.Windows.Forms.CheckBox();
            this.cBoxClient = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTES DES CLIENTS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.cBoxClient);
            this.panel1.Controls.Add(this.cbClient);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(54, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 301);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(45, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbClient
            // 
            this.cbClient.AutoSize = true;
            this.cbClient.Location = new System.Drawing.Point(554, 49);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(152, 21);
            this.cbClient.TabIndex = 1;
            this.cbClient.Text = "Supprimer un client";
            this.cbClient.UseVisualStyleBackColor = true;
            this.cbClient.CheckedChanged += new System.EventHandler(this.cbClient_CheckedChanged);
            // 
            // cBoxClient
            // 
            this.cBoxClient.FormattingEnabled = true;
            this.cBoxClient.Location = new System.Drawing.Point(554, 105);
            this.cBoxClient.Name = "cBoxClient";
            this.cBoxClient.Size = new System.Drawing.Size(121, 24);
            this.cBoxClient.TabIndex = 2;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(566, 211);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(93, 38);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Supprimer";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // DisplayCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion.Properties.Resources.aloe_vera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DisplayCustomer";
            this.Text = "DisplayCustomer";
            this.Load += new System.EventHandler(this.DisplayCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbClient;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox cBoxClient;
    }
}