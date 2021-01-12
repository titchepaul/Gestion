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
    public partial class Ventes : Form
    {
        List<String> list = null;
        public Ventes()
        {
            InitializeComponent();
            Connection_Deconnection.connect();
        }

        private void remplirList()
        {
            try
            {
                list = new List<string>();
                //requête sql
                String query = "SELECT nomProduits FROM Produits";

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

        private void Ventes_Load(object sender, EventArgs e)
        {
            remplirList();
            foreach (String i in list)
            {
                cbVentes.Items.Add(i);
            }
        }
        public void insertValue(String nomProduit, double prixProduit, String date, int nbreProduit)
        {
            try
            {
                //String strToReplace = tbPrixProduit.Text.ToString().Replace('.', ',');
                ////double prixProduit = Convert.ToDouble(strToReplace);

                String str = nomProduit;
                double str1 = prixProduit;
                String str2 = date;
                int str3 = nbreProduit;
                String query = String.Format("INSERT INTO Vendus (nomProduits,prixProduits,nbreProduits,[date]) VALUES (@valuestr, @valuestr1,@valuestr3,@valuestr2)");
                //String query = String.Format("INSERT INTO Vendus (nomProduits,prixProduits,nbreProduits,[date]) Values ('"+str+"',"+str1+","+str3+",'"+str2+"')");

                //MessageBox.Show(query);
                //MessageBox.Show(str + " " + str1 + " " + str2 + " " + str3);
                OleDbCommand sql = new OleDbCommand(query, Connection_Deconnection.connection);
                sql.Parameters.AddWithValue("@valuestr", str);
                sql.Parameters.AddWithValue("@valuesstr1", str1);
                sql.Parameters.AddWithValue("@valuesstr3", str3);
                sql.Parameters.AddWithValue("@valuesstr2", str2);
                //sql.Parameters.AddWithValue("@valuesstr3", str3);
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
        public void clearTextBox()
        {
            this.tbPrixProduit.Clear();
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

        private void btSaveVentes_Click(object sender, EventArgs e)
        {
            if(!(cbVentes.Text.Equals("") || tbPrixProduit.Text.Equals("") || nUpDownQuantite.Value.Equals(0)))
            {
                String strToReplace = tbPrixProduit.Text.ToString().Replace('.', ',');
                double prixProduit = Convert.ToDouble(strToReplace);

               // MessageBox.Show(""+prixProduit);
                DateTime DateValue = Convert.ToDateTime(dtVentes.Value);
                String dd = DateValue.ToString("dd/MM/yyyy");
                String dateProduit = dd + "";

                int nbProduit = Convert.ToInt32(nUpDownQuantite.Value);
                insertValue(cbVentes.Text, prixProduit, dateProduit, nbProduit);
            }
            else
            {
                MessageBox.Show("Veuillez revoir vos champs svp :");
            }
        }
    }
}
