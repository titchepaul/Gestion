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
    public partial class Restant : Form
    {
        Dictionary<string, int> myProduit = new Dictionary<string, int>();
        Dictionary<string, int> myselling = new Dictionary<string, int>();
        public Restant()
        {
            InitializeComponent();
        }

        private void Restant_Load(object sender, EventArgs e)
        {
            displayGrid();
        }
        public void displayGrid()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "NOM DU PRODUIT";
            dataGridView1.Columns[1].Name = "PRIX DU PRODUIT";
            dataGridView1.Columns[2].Name = "STOCK INITIAL";
            dataGridView1.Columns[3].Name = "VENDUE(S)";
            dataGridView1.Columns[4].Name = "RESTANT(S)";

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
                    int nbreProduit;
                    nomProduit = (String)reader[0];
                    nbreProduit = (int)reader[2];
                    //myValue = nbreProduit;

                    if (myselling.ContainsKey(nomProduit))
                    {
                        myselling[nomProduit] = myselling[nomProduit] + nbreProduit;
                    }
                    else
                    {
                        myselling.Add(nomProduit, nbreProduit);
                    }

                    //row = new String[4];
                    ////row[3] = nomProduit;                   
                    //row[3] = nbreProduit + "";

                    //dataGridView1.Rows.Add(row);
                }
                reader.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Connection_Deconnection.deconnect();
            }
            try
            {
                //requête sql
                String query = "SELECT * FROM Produits";

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
                    int nbreProduit;
                    nomProduit = (String)reader[0];
                    prixProduit = "€" + Convert.ToDouble(reader[1]);                    
                    nbreProduit = (int)reader[3];

                    myProduit.Add(nomProduit, nbreProduit);
                    row = new String[5];
                    row[0] = nomProduit;
                    row[1] = prixProduit + "";                    
                    row[2] = nbreProduit + "";

                    if (myselling.ContainsKey(nomProduit))
                    {
                        row[3] = myselling[nomProduit] + "";
                    }
                    else
                    {
                        row[3] = 0 + "";
                    }

                    if (myProduit.ContainsKey(nomProduit))
                    {
                        if (myselling.ContainsKey(nomProduit))
                        {
                            row[4] = ""+ (myProduit[nomProduit] - myselling[nomProduit]);
                        }
                        else
                        {
                            row[4] = 0 + "";
                        }
                    }
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

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.ReadOnly = true;
            //dataGridView1.Rows[1].ReadOnly = true;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
