using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    class Connection_Deconnection
    {

        public static OleDbConnection connection;
        //OleDbDataAdapter dataAdapter;
        // OleDbCommandBuilder commandBuilder;

        public static void connect()
        {
            String cs = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source = MyDataBase.accdb";
            connection = new OleDbConnection();
            connection.ConnectionString = cs;
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void deconnect()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
