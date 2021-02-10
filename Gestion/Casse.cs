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
    public partial class Casse : Form
    {
        List<String> list = null;
        List<String> listOfCasse = null;
        public Casse()
        {
            InitializeComponent();
            Connection_Deconnection.connect();
        }

        private void Casse_Load(object sender, EventArgs e)
        {
            cbCasse.Visible = false;
            btSupprimer.Visible = false;

            remplirList();
            remplirListOfCasse();
            //pour l'ajout
            foreach (string str in list)
            {
                cbNomProduit.Items.Add(str);
            }
            //pour la suppression
            foreach(string casses in listOfCasse)
            {
                cbCasse.Items.Add(casses);
            }
        }
        public void insertValue(string nomProduits, string date, double productPrice, int nbCasse)
        {
            try
            {
                String productsName = nomProduits;
                double prixProduit = productPrice;
                String dayOfDate = date;
                int casse = nbCasse;
                String query = String.Format("INSERT INTO Casses (nomProduits,[date], prixProduits, nbreCasses) VALUES (@valuestr, @valuestr1,@valuestr2,@valuestr3)");
                //String query = String.Format("INSERT INTO Produits (nomProduits,prixProduits,date,nbreProduits) Values ('"+str+"','"+str1+"','"+str2+"','"+str3+"')");

                //MessageBox.Show(query);
                //MessageBox.Show(str + " " + str1 + " " + str2 + " " + str3);
                OleDbCommand sql = new OleDbCommand(query, Connection_Deconnection.connection);
                sql.Parameters.AddWithValue("@valuestr", productsName);
                sql.Parameters.AddWithValue("@valuestr1", dayOfDate);
                sql.Parameters.AddWithValue("@valuestr2", prixProduit);
                sql.Parameters.AddWithValue("@valuestr3", casse);

                int rows = sql.ExecuteNonQuery();
                if (rows == 1)
                {
                    MessageBox.Show("Données insérées avec succès ");
                    //this.clearTextBox();
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
        /*
         * pour le produit
         * */
        private void remplirList()
        {
            try
            {
                list = new List<string>();
                //requête sql
                String query = "SELECT nomProduits" +
                    " FROM Produits";

                // lire l'enrégistrement
                OleDbCommand sql = new OleDbCommand();
                sql.CommandText = query;
                sql.Connection = Connection_Deconnection.connection;
                sql.CommandType = System.Data.CommandType.Text;

                //le reader curseur
                OleDbDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    list.Add((String)reader[0]);
                }
                reader.Close();
                //Connection_Deconnection.deconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors de la récupération des données " + e.Message);
                Connection_Deconnection.deconnect();
            }
        }
        private void remplirListOfCasse()
        {
            try
            {
                listOfCasse = new List<string>();
                //requête sql
                String query = "SELECT nomProduits" +
                    " FROM Casses";

                // lire l'enrégistrement
                OleDbCommand sql = new OleDbCommand();
                sql.CommandText = query;
                sql.Connection = Connection_Deconnection.connection;
                sql.CommandType = System.Data.CommandType.Text;

                //le reader curseur
                OleDbDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    listOfCasse.Add((String)reader[0]);
                }
                reader.Close();
                //Connection_Deconnection.deconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors de la récupération des données " + e.Message);
                Connection_Deconnection.deconnect();
            }
        }

        private void tbPrixProduit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!(cbNomProduit.Text.Equals("") || tbPrixProduit.Text.Equals("")))
            {
                //pour le prix
                String strToReplace = tbPrixProduit.Text.ToString().Replace('.', ',');
                double prixProduit = Convert.ToDouble(strToReplace);

                //pour la date
                DateTime DateValue = Convert.ToDateTime(dtPicker.Value);
                String dd = DateValue.ToString("dd/MM/yyyy");
                String dateProduit = dd + "";

                int casse = Convert.ToInt32(nbreCasse.Value);

                if (casse != 0)
                {
                   // MessageBox.Show("casse : " + cbNomProduit.Text);
                    insertValue(cbNomProduit.Text, dateProduit, prixProduit, casse);
                }
                else
                {
                    MessageBox.Show("Le nombre de(s) casse(s) ne peut pas être égale à 0");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs svp :");
            }
        }

        private void cbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDelete.Checked == true)
            {
                cbCasse.Visible = true;
                btSupprimer.Visible = true;
            }
            else
            {
                cbCasse.Visible = false;
                btSupprimer.Visible = false;
            }
        }
        private void deleteClient(string nomProduits)
        {
            try
            {
                String query = String.Format("DELETE * FROM Casses WHERE nomProduits = " + "'" + nomProduits + "'");
                //MessageBox.Show(query);
                OleDbCommand sql = new OleDbCommand(query, Connection_Deconnection.connection);
                int rows = sql.ExecuteNonQuery();
                if (rows >= 1)
                {
                    MessageBox.Show("Casse supprimée avec succès ");
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression ");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            string getValue = cbCasse.Text;
            if (!getValue.Equals(""))
            {
                deleteClient(getValue);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListeDesCasses listeDesCasses = new ListeDesCasses();
            listeDesCasses.ShowDialog();
        }
    }
}
