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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
           // this.BackgroundImage = Properties.Resources.a;
            InitializeComponent();
            Connection_Deconnection.connect();
            displayGrid();
            //deleteAll();
            this.BackgroundImage = Properties.Resources.aloe_vera;
            ////Timer tm = new Timer();
            ////tm.Interval = 10000;
            ////tm.Tick += new EventHandler(changeImage);
            ////tm.Start();
        }
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> bmp = new List<Bitmap>();
            //bmp.Add(Properties.Resources.aloe_1);
            //bmp.Add(Properties.Resources.aloe_2);
            //bmp.Add(Properties.Resources.aloe_3);
            bmp.Add(Properties.Resources.aloe_vera);
            int index = DateTime.Now.Second % bmp.Count;
            this.BackgroundImage = bmp[index];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bEncodage_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            
            f2.ShowDialog();
        }
        private void deleteAll()
        {
            try
            {                
                String query = String.Format("DELETE * FROM Vendus");
                MessageBox.Show(query);
                OleDbCommand sql = new OleDbCommand(query, Connection_Deconnection.connection);
                int rows = sql.ExecuteNonQuery();
                if (rows == 1)
                {
                    MessageBox.Show(rows + " supprimer avec succès ");
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
        public void displayGrid()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "NOM DU PRODUIT";
            dataGridView1.Columns[1].Name = "PRIX DU PRODUIT";
            dataGridView1.Columns[2].Name = "DATE";
            dataGridView1.Columns[3].Name = "NOMBRE DE PRODUIT(S)";

            string[] row;
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
                    String date;
                    int nbreProduit;
                    nomProduit = (String)reader[0];
                    prixProduit = "€" +  Convert.ToDouble(reader[1]);
                    date = (String)reader[2];
                    nbreProduit = (int)reader[3];

                    row = new String[4];
                    row[0] = nomProduit;
                    row[1] = prixProduit +"";
                    row[2] = date;
                    row[3] = nbreProduit + "";
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
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.ReadOnly = true;
            //dataGridView1.Rows[1].ReadOnly = true;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Modification formMod = new Modification();
            formMod.ShowDialog();
        }

        private void btAffichageVentes_Click(object sender, EventArgs e)
        {
            ListeVentes listeVentes = new ListeVentes();
            listeVentes.ShowDialog();
        }

        private void btVentes_Click(object sender, EventArgs e)
        {
            Ventes vt = new Ventes();
            vt.ShowDialog();
        }

        private void btClients_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.ShowDialog();
        }

        private void btListeClient_Click(object sender, EventArgs e)
        {
            DisplayCustomer displayCustomer = new DisplayCustomer();
            displayCustomer.ShowDialog();
        }
    }
}
