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
    public partial class Modification : Form
    {
        List<String> list = null;
        Form1 display = (Form1)Application.OpenForms["Form1"];
        public Modification()
        {
            InitializeComponent();           
            Connection_Deconnection.connect();
        }

        private void Modification_Load(object sender, EventArgs e)
        {
            remplirList();
            foreach(String i in list)
            {
                cbProduit.Items.Add(i);
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            Produit prod = new Produit();
            if (cbProduit.Text.Equals(""))
            {
                MessageBox.Show("Veuillez sélectionner un nom de produit valide svp");
            }
            else
            {
                prod.updateProduct(cbProduit.Text);
                prod.ShowDialog();
            }
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
        private void deleteAll(string nomProduit)
        {
            try
            {
                String query = String.Format("DELETE * FROM Produits WHERE nomProduits = "+"'"+nomProduit+"'");
                //MessageBox.Show(query);
                OleDbCommand sql = new OleDbCommand(query, Connection_Deconnection.connection);
                int rows = sql.ExecuteNonQuery();
                if (rows == 1)
                {
                    MessageBox.Show(nomProduit + " a été supprimer avec succès ");
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
        private bool confirmQuit()
        {
            // message confirmation de suppression 
            if (MessageBox.Show("Attention !! Cette action est irréversible, êtes-vous sûr de vouloir supprimer ce produit ?",
                               "Message de confirmation",
                               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // non
                return false;
            }
            else
            {
                return true;
            }

        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (cbProduit.Text.Equals(""))
            {
                MessageBox.Show("Veuillez sélectionner un nom de produit valide svp");
            }
            else
            {
                if(confirmQuit() != false)
                {
                    deleteAll(cbProduit.Text);
                    display.displayGrid();
                }
            }
        }
    }
}
