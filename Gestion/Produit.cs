using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Produit : Form
    {
        Form1 display = (Form1)Application.OpenForms["Form1"];
        public Produit()
        {
            InitializeComponent();
            Connection_Deconnection.connect();
            tbEnterDate.ReadOnly = true;
            dtpProd.Enabled = false;
            tbNomProd.Enabled = false;
            //enabledButton();
        }
        //private void enabledButton()
        //{
        //    if(cbox.Enabled == true)
        //    {
        //        dtpProd.Enabled = true;
        //    }
        //    else
        //    {
        //        dtpProd.Enabled = false;
        //    }
        //}
        private void updateToSetProduct(string nomProduit, double productPrice, string date, int numberOfProduit)
        {
            if(!(tbPrixProd.Text.Equals("") || tbNombreProd.Text.Equals("")))
            {
                try
                {
                    //insert, update, delete
                    double prixProduit = productPrice;
                    String produitDate = date;
                    int nbreDeProduit = numberOfProduit;
                    String query = String.Format("UPDATE Produits SET prixProduits=@valueprixProduit , [date]=@valueDate, nbreProduits=@valueNbreProduit WHERE nomProduits=" +"'"+ nomProduit+"'");
                    //MessageBox.Show(query);
                    OleDbCommand sql = new OleDbCommand(query, Connection_Deconnection.connection);
                    sql.Parameters.AddWithValue("@valueprixProduit", prixProduit);
                    sql.Parameters.AddWithValue("@valueDate", produitDate);
                    sql.Parameters.AddWithValue("@valueNbreProduit", nbreDeProduit);
                    int rows = sql.ExecuteNonQuery();
                    if (rows == 1)
                    {
                        MessageBox.Show("Données modifiées avec succès ");
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification ");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur " + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs svp :");
            }
        }
        private void Produit_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void updateProduct(String productName)
        {
            try
            {
                //requête sql
                String query = "SELECT * FROM Produits WHERE nomProduits= '"+ productName+"'";

                // lire l'enrégistrement
                OleDbCommand sql = new OleDbCommand();
                sql.CommandText = query;
                sql.Connection = Connection_Deconnection.connection;
                sql.CommandType = System.Data.CommandType.Text;

                //le reader curseur
                OleDbDataReader reader = sql.ExecuteReader();

                if(reader.Read())
                {
                    this.tbNomProd.Text = (String)reader[0];
                    this.tbPrixProd.Text = reader[1].ToString();
                    this.tbEnterDate.Text = reader[2].ToString();
                    this.tbNombreProd.Text = reader[3].ToString();
                }
                else
                {
                    MessageBox.Show("Pas d'enrégistrement trouvée ");
                }
            }
            catch (Exception e)
            {
                Connection_Deconnection.deconnect();
                MessageBox.Show("Erreur de lecture des données " + e.Message);
            }
        }

        private void tbPrixProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbNomProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!(!char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
            {
                e.Handled = true;
            }
        }

        private void tbNomProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void cbox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox.Checked == true)
            {
                dtpProd.Enabled = true;
            }
            else
            {
                dtpProd.Enabled = false;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!(tbPrixProd.Text.Equals("") || tbNombreProd.Text.Equals("")))
            {
                //pour le prix
                String strToReplace = tbPrixProd.Text.ToString().Replace('.', ',');
                double prixProduit = Convert.ToDouble(strToReplace);

                //pour la date
                DateTime DateValue = Convert.ToDateTime(dtpProd.Value);
                String dd = DateValue.ToString("dd/MM/yyyy");
                String dateProduit = dd + "";

                int nbProduit = Convert.ToInt32(tbNombreProd.Text);

                if (cbox.Checked == true)
                {
                    updateToSetProduct(tbNomProd.Text, prixProduit, dateProduit, nbProduit);
                    display.displayGrid();
                }
                else
                {
                    updateToSetProduct(tbNomProd.Text, prixProduit, tbEnterDate.Text, nbProduit);
                    display.displayGrid();
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs svp :");
            }
        }

        private void tbNombreProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }          
        }

        private void tbNombreProd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
