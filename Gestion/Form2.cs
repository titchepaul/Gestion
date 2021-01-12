using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Form2 : Form
    {

        Form1 display = (Form1) Application.OpenForms["Form1"];
        public Form2()
        {
            InitializeComponent();
            Connection_Deconnection.connect();
            //this.display.displayGrid();
            //Form1 display = new Form1();
            //this.BackgroundImage = Properties.Resources.aloe_vera;
            //string previousInput = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void gEncodage_Enter(object sender, EventArgs e)
        {

        }

        private void bSubmit_Click(object sender, EventArgs e)
        {

            if (!(tNomProduit.Text.Equals("") || tPrixProduit.Text.Equals("") || tnbProduit.Text.Equals("")))
            {               
                    String strToReplace = tPrixProduit.Text.ToString().Replace('.', ',');
                    double prixProduit = Convert.ToDouble(strToReplace);

                    DateTime DateValue = Convert.ToDateTime(dtProduit.Value);
                    String dd = DateValue.ToString("dd/MM/yyyy");                  
                    String dateProduit = dd + "";

                    //MessageBox.Show("" + prixProduit);

                    int nbProduit = Convert.ToInt32(tnbProduit.Text);
                    if(nbProduit != 0)
                    {
                        insertValue(tNomProduit.Text, prixProduit, dateProduit, nbProduit);
                        this.display.displayGrid();
                    }
                    else
                    {
                        MessageBox.Show("Le nombre d'unité de produit ne peut pas être égal à 0 ");
                    }               
            }
            else
            {
                MessageBox.Show("L'encodage ne peut pas contenir un champs vide, Veuillez revoir vos champs s'il vous plaît !!");
            }
            //double prixProduit = Convert.ToDouble(tPrixProduit.Text);
            //String dateProduit = dtProduit.Text.ToString();
            //int nbProduit = Convert.ToInt32( tnbProduit.Text);
            //insertValue(nomProduit, prixProduit, dateProduit, nbProduit);
        }
        public void insertValue(String nomProduit, double prixProduit, String date, int nbreProduit)
        {
            try
            {
                String str = nomProduit;
                double str1 = prixProduit;
                String str2 = date;
                int str3 = nbreProduit;
                String query = String.Format("INSERT INTO Produits (nomProduits,prixProduits,[date],nbreProduits) VALUES (@valuestr, @valuestr1,@valuestr2,@valuestr3)");
                //String query = String.Format("INSERT INTO Produits (nomProduits,prixProduits,date,nbreProduits) Values ('"+str+"','"+str1+"','"+str2+"','"+str3+"')");
           
                //MessageBox.Show(query);
                //MessageBox.Show(str + " " + str1 + " " + str2 + " " + str3);
                OleDbCommand sql = new OleDbCommand(query, Connection_Deconnection.connection);
                sql.Parameters.AddWithValue("@valuestr", str);
                sql.Parameters.AddWithValue("@valuesstr1", str1);
                sql.Parameters.AddWithValue("@valuesstr2", str2);
                sql.Parameters.AddWithValue("@valuesstr3", str3);
                int rows = sql.ExecuteNonQuery();
                if (rows == 1)
                {
                    MessageBox.Show("Données insérées avec succès ");
                    this.clearTextBox();
                }
                else
                {
                    MessageBox.Show("Erreur d'insertion ");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tNomProduit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tPrixProduit_TextChanged(object sender, EventArgs e)
        {
            //System.Text.RegularExpressions.Regex r = new Regex("^.{0,1}*$"); // This is the main part, can be altered to match any desired form or limitations
            //Match m = r.Match(tPrixProduit.Text);
            //if (m.Success)
            //{
            //    previousInput = tPrixProduit.Text;
            //}
            //else
            //{
            //    tPrixProduit.Text = previousInput;
            //}
        }

        private void tPrixProduit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tNomProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!(!char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
            {
                e.Handled = true;
            }
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tNomProduit_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }
        public void clearTextBox()
        {
            this.tNomProduit.Clear();
            this.tPrixProduit.Clear();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
