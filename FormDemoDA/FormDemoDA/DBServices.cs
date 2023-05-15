using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormDemoDA
{
    internal class DBServices
    {
        private string conn = @"Data Source=LAPTOP-VL2DNGOC\SQLEXPRESS;Initial Catalog=BOOKRENTAL;Integrated Security=True";
        private SqlConnection mySqlConnetion;

        public DBServices()
        {
            mySqlConnetion = new SqlConnection(conn);
        }

        public DataTable getData(string sSql)
        {
            try
            {
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(sSql, mySqlConnetion);
                DataTable myDataTable = new DataTable();
                myDataAdapter.Fill(myDataTable);
                return myDataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public void runQuery(string sSql)
        {
            try
            {
                mySqlConnetion.Open();
                SqlCommand mySqlCommand = new SqlCommand(sSql, mySqlConnetion);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnetion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
    }
}
