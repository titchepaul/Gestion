namespace Gestion
{
    partial class Clients
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
            this.tbNameClient = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENCODAGE DES DONNEES CLIENTS :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // tbNameClient
            // 
            this.tbNameClient.Location = new System.Drawing.Point(328, 115);
            this.tbNameClient.Name = "tbNameClient";
            this.tbNameClient.Size = new System.Drawing.Size(138, 22);
            this.tbNameClient.TabIndex = 2;
            this.tbNameClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNameClient_KeyPress);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(328, 177);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(138, 22);
            this.tbPhoneNumber.TabIndex = 3;
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number :";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(328, 284);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(110, 39);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Enrégistrer";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbNameClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameClient;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSave;
    }
}