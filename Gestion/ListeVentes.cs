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
    public partial class ListeVentes : Form
    {
        public ListeVentes()
        {
            InitializeComponent();
        }

        private void ListeVentes_Load(object sender, EventArgs e)
        {
            displayGrid();
        }
        private void displayGrid()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "NOM DU PRODUIT";
            dataGridView1.Columns[1].Name = "PRIX DU PRODUIT";
            dataGridView1.Columns[2].Name = "NOMBRE DE PRODUIT(S)";
            dataGridView1.Columns[3].Name = "DATE";

            string[] row;
            try
            {
                //requête sql
                String query = "SELECT * FROM Vendus";

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
                    prixProduit = "€" + Convert.ToDouble(reader[1]);
                    date = (String)reader[3];
                    nbreProduit = (int)reader[2];

                    row = new String[4];
                    row[0] = nomProduit;
                    row[1] = prixProduit + "";
                    row[3] = date;
                    row[2] = nbreProduit + "";
                    //for(int i=0; i<= row.Length-1; i++)
                    //{
                    //    row[i] = (String)reader[i + 1];
                    //}
                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
                //Connection_Deconnection.deconnect();
                //Connection_Deconnection.deconnect();
                //else
                //{                    
                //    MessageBox.Show("aucun enrégistrement trouvé ");
                //    Connection_Deconnection.deconnect();
                //}
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

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
