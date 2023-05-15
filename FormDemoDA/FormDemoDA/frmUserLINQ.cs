using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemoDA
{
    public partial class frmUserLINQ : Form
    {
        BOOKRENTALEntities myBook = new BOOKRENTALEntities();
        private bool addNew = false;
        public frmUserLINQ()
        {
            InitializeComponent();
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
            txtEmail.Text = dataGridView1.Rows[i].Cells["email"].Value == null? "": dataGridView1.Rows[i].Cells["email"].Value.ToString();
            txtStatus.Text = dataGridView1.Rows[i].Cells["Status"].Value.ToString();
        }

        private void frmUserLINQ_Load(object sender, EventArgs e)
        {
            getDataGridView();
            addNew = true;
            setEnable(false);
        }

        private void setEnable(bool check) 
        {
            txtUserID.Enabled = false;
            txtFullName.Enabled = check;
            txtPassword.Enabled = check;
            txtPhone.Enabled = check;
            txtUserName.Enabled = check;
            txtEmail.Enabled = check;
            txtStatus.Enabled = check;
            btnAddNew.Enabled = !check;
            btnDelete.Enabled = !check;
            btnEdit.Enabled = !check;
            btnSave.Enabled = check;
            btnCancel.Enabled = check;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtUserName.Clear();
            txtEmail.Clear();
            txtStatus.Clear();

            addNew = true;
            setEnable(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addNew)
            {
                User u1 = new User();
                string index;
                string sql = 
                    "declare @valueID int;" +
                    "exec getId @valueID out;" +
                    "select @valueid;";
                DBServices db = new DBServices();
                DataTable dt = db.getData(sql);
                index = dt.Rows[0][0].ToString();
                u1.UserID = "Us" + index;
                u1.FullName = txtFullName.Text;
                u1.UserName = txtUserName.Text;
                u1.Email = txtEmail.Text;
                u1.Password = txtPassword.Text;
                u1.Phone = txtPhone.Text;
                u1.Status = txtStatus.Text;
                myBook.Users.Add(u1);
                myBook.SaveChanges();
                getDataGridView();
            }else
            {
                string id = txtUserID.Text;
                var queryUsers = from item in myBook.Users 
                                 where (item.UserID == id) 
                                 select item;
                User itemUser = queryUsers.First();
                string st = txtStatus.Text;
                itemUser.FullName = txtFullName.Text;
                itemUser.UserName = txtUserName.Text;
                itemUser.Email = txtEmail.Text;
                itemUser.Password = txtPassword.Text;
                itemUser.Phone = txtPhone.Text;
                itemUser.Status = st;
                myBook.SaveChanges();
            }
            btnCancel_Click(sender, e);
            addNew = false;
            setEnable(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtFullName.Clear();
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtStatus.Clear();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addNew = false;
            setEnable(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtUserID.Text;
                var queryUser = from item in myBook.Users 
                                where item.UserID == id 
                                select item;
                myBook.Users.Remove(queryUser.First());
                myBook.SaveChanges();
                getDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
