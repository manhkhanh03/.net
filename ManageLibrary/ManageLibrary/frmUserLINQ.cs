using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageLibrary
{
    public partial class frmUserLINQ : Form
    {
        BOOKRENTALEntities myBook = new BOOKRENTALEntities();
        private  bool addNew = false;
        public frmUserLINQ()
        {
            InitializeComponent();
        }

        private void frmUserLINQ_Load(object sender, EventArgs e)
        {
            getDataGridView();
        }
            
        private void getDataGridView()
        {
            var queryUser = from item in myBook.Users select item;
            dataGridView1.DataSource = queryUser.ToList();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtUserID.Text = dataGridView1.Rows[i].Cells["UserID"].Value.ToString();
            txtFullName.Text = dataGridView1.Rows[i].Cells["FullName"].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[i].Cells["Password"].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells["Phone"].Value.ToString();
            txtUserName.Text = dataGridView1.Rows[i].Cells["UserName"].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[i].Cells["Email"].Value.ToString();
            txtStatus.Text = dataGridView1.Rows[i].Cells["Status"].Value.ToString();
        }
    }
}
