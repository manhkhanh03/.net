using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace nganNT
{
    public partial class Form1 : Form
    {
        private string conn = @"Data Source=LAPTOP-VL2DNGOC\SQLEXPRESS;Initial Catalog=RestaurantManager;Integrated Security=True";
        private SqlConnection mySqlConnection;

        public DataTable getData(string sql)
        {
            try
            {
                SqlDataAdapter myDataAdepter = new SqlDataAdapter(sql, mySqlConnection);
                DataTable myDataTable = new DataTable();
                myDataAdepter.Fill(myDataTable);
                return myDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void runQuery(string sql)
        {
            try
            {
                mySqlConnection.Open();
                SqlCommand mySqlCommand = new SqlCommand(sql, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        public Form1()
        {
            InitializeComponent();
            //mySqlConnection = new SqlConnection(conn);
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool Nguyento(int n)
        {
            if(n<=1) return  false ;
            for(int i=2; i<= Math.Sqrt(n);i++)
                if(n%i ==0) return false ;  
            return true ;   
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string conn = @"Data Source=LAPTOP-VL2DNGOC\SQLEXPRESS;Initial Catalog=RestaurantManager;Integrated Security=True";

            //listView1.Columns.Add("Name");
            //listView1.Columns.Add("Quantity");
            //listView1.Columns.Add("Price");
            //List<MenuItem> menuItems = new List<MenuItem>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string sql = "SELECT Orders.OrderID, NameDish, Quantity, orders.Price " +
                    "from(orders join Booking on Orders.BookID = Booking.BookID) join Dishs on Dishs.DishID = Orders.DishID " +
                    $"where Orders.BookID = 'Book3' " +
                    "group by Orders.OrderID, NameDish, Quantity, orders.Price";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                listView1.Columns.Add(reader.GetName(0));
                listView1.Columns.Add(reader.GetName(1), 150);
                listView1.Columns.Add(reader.GetName(2));
                listView1.Columns.Add(reader.GetName(3), 100);
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetInt32(2).ToString());
                    item.SubItems.Add(reader.GetDecimal(3).ToString());
                    listView1.Items.Add(item);
                }

                reader.Close();
                connection.Close();
            }






            // Tạo một đối tượng ListViewItem mới với tên là "Burger"
            //ListViewItem item = new ListViewItem("Burger");

            //// Thêm các subitem tương ứng với số lượng và giá
            //item.SubItems.Add("2");
            //item.SubItems.Add("5.99");

            //// Thêm item vào ListView
            //listView1.Items.Add(item);


        }
    }
}
