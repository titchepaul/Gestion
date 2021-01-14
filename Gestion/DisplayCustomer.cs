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
    public partial class DisplayCustomer : Form
    {
        public DisplayCustomer()
        {
            InitializeComponent();
            displayGrid();
        }

        private void DisplayCustomer_Load(object sender, EventArgs e)
        {

        }
        public void displayGrid()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "NOM DU CLIENT";
            dataGridView1.Columns[1].Name = "NUMÉRO DU CLIENT";
            dataGridView1.Columns[2].Name = "DATE";            

            string[] row;
            try
            {
                //requête sql
                String query = "SELECT * FROM Clients";

                // lire l'enrégistrement
                OleDbCommand sql = new OleDbCommand();
                sql.CommandText = query;
                sql.Connection = Connection_Deconnection.connection;
                sql.CommandType = System.Data.CommandType.Text;

                //le reader curseur
                OleDbDataReader reader = sql.ExecuteReader();
                while (reader.Read() == true)
                {
                    String customerName;
                    int customerNumber;
                    String date;
                    
                    customerName = (String)reader[0];
                    customerNumber = (int)(reader[1]);
                    date = (String)reader[2];                   

                    row = new String[4];
                    row[0] = customerName;
                    row[1] = customerNumber + "";
                    row[2] = date;
                    //row[3] = nbreProduit + "";
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

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.ReadOnly = true;
            //dataGridView1.Rows[1].ReadOnly = true;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void cbClient_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
