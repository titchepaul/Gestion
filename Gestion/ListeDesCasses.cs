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
    public partial class ListeDesCasses : Form
    {
        public ListeDesCasses()
        {
            InitializeComponent();
        }

        private void ListeDesCasses_Load(object sender, EventArgs e)
        {
            displayGrid();
        }
        private void displayGrid()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "NOM DU PRODUIT";
            dataGridView1.Columns[1].Name = "DATE DES CASSE(S)";
            dataGridView1.Columns[2].Name = "PRIX DU PRODUIT(S)";
            dataGridView1.Columns[3].Name = "NOMBRE D'ARTICLES CASSÉ(S)";

            string[] row;
            try
            {
                //requête sql
                String query = "SELECT * FROM Casses";

                // lire l'enrégistrement
                OleDbCommand sql = new OleDbCommand();
                sql.CommandText = query;
                sql.Connection = Connection_Deconnection.connection;
                sql.CommandType = System.Data.CommandType.Text;

                //le reader curseur
                OleDbDataReader reader = sql.ExecuteReader();
                while (reader.Read() == true)
                {
                    String nomProduit;
                    String prixProduit;
                    String date;
                    int nbreProduit;
                    nomProduit = (String)reader[0];
                    prixProduit = "€" + Convert.ToDouble(reader[2]);
                    date = (String)reader[1];
                    nbreProduit = (int)reader[3];

                    row = new String[4];
                    row[0] = nomProduit;
                    row[2] = prixProduit + "";
                    row[1] = date;
                    row[3] = nbreProduit + "";
                   
                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Connection_Deconnection.deconnect();
            }

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.ReadOnly = true;
            //dataGridView1.Rows[1].ReadOnly = true;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
