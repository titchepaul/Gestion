namespace Gestion
{
    partial class Modification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modification));
            this.label1 = new System.Windows.Forms.Label();
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.btModifier = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez sélectionnez le produit à Modifier/Supprimer svp : ";
            // 
            // cbProduit
            // 
            this.cbProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Location = new System.Drawing.Point(259, 119);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(160, 24);
            this.cbProduit.TabIndex = 1;
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(122, 285);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(109, 42);
            this.btModifier.TabIndex = 2;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(387, 285);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(107, 42);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Supprimer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 421);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.cbProduit);
            this.Controls.Add(this.label1);
            this.Name = "Modification";
            this.Text = "Modification";
            this.Load += new System.EventHandler(this.Modification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProduit;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btDelete;
    }
}