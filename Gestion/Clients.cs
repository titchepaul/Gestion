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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void tbNameClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!(!char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
            {
                e.Handled = true;
            }
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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
        public void insertValue(string nomClient, int numeroTel, string date)
        {
            try
            {
                String customerName = nomClient;
                int phoneNumber = numeroTel;
                String dayOfDate = date;
                String query = String.Format("INSERT INTO Clients (nomClients,Numero,[date]) VALUES (@valuestr, @valuestr1,@valuestr2)");
                //String query = String.Format("INSERT INTO Produits (nomProduits,prixProduits,date,nbreProduits) Values ('"+str+"','"+str1+"','"+str2+"','"+str3+"')");

                //MessageBox.Show(query);
                //MessageBox.Show(str + " " + str1 + " " + str2 + " " + str3);
                OleDbCommand sql = new OleDbCommand(query, Connection_Deconnection.connection);
                sql.Parameters.AddWithValue("@valuestr", customerName);
                sql.Parameters.AddWithValue("@valuesstr1", phoneNumber);
                sql.Parameters.AddWithValue("@valuesstr2", dayOfDate);
             
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

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!(tbNameClient.Text.Equals("") || tbPhoneNumber.Text.Equals("") || dtPicker.Text.Equals("")))
            {
                String strToReplace = tbPhoneNumber.Text.ToString().Replace(',', '.');
                double number = Convert.ToDouble(strToReplace);
                int finallyNumber = Convert.ToInt32(number);

                DateTime DateValue = Convert.ToDateTime(dtPicker.Value);
                String dd = DateValue.ToString("dd/MM/yyyy");
                String dateOfClient = dd + "";

                //MessageBox.Show("" + prixProduit);

                    insertValue(tbNameClient.Text,finallyNumber,dateOfClient);
                this.clearTextBox();
                                 
            }
            else
            {
                MessageBox.Show("L'encodage ne peut pas contenir un champs vide, Veuillez revoir vos champs s'il vous plaît !!");
            }
        }
        public void clearTextBox()
        {
            this.tbNameClient.Clear();
            this.tbPhoneNumber.Clear();

        }
    }
}
