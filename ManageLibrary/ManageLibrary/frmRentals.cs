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
    public partial class frmRentals : Form
    {
        
        bool addNew = false;
        public frmRentals()
        {
            InitializeComponent();
        }

        private void frmRentals_Load(object sender, EventArgs e)
        {
            setEnable(false);

            getDataGridView();
            getDataUsers();
            getDataCustomers();
        }

        private void setEnable(bool check)
        {
            txtRentalID.Enabled = false;
            lbUser.Enabled = check;
            cbCustomer.Enabled = check;
            txtRentalDate.Enabled = check;
            txtReturnDate.Enabled = check;
            txtDeposit.Enabled = check;
            txtDescription.Enabled = check;
            btnSave.Enabled = check;
            btnCancel.Enabled = check;
            btnAddNew.Enabled = !check;
            btnDelete.Enabled = !check;
            btnEdit.Enabled = !check;
            btnExit.Enabled = !check;

        }

        private void getDataGridView()
        {
            DBServices db = new DBServices();
            string sql = "SELECT * FROM RENTAL";
            dataGridView1.DataSource = db.getData(sql);
        }

        private void getDataUsers()
        {
            DBServices db = new DBServices();
            string sql = "SELECT * FROM USERS WHERE STATUS = '1'";
            lbUser.DisplayMember = "FULLNAME";
            lbUser.ValueMember = "userid";
            lbUser.DataSource = db.getData(sql);
        }

        private void getDataCustomers()
        {
            DBServices db = new DBServices();
            string sql = "SELECT * FROM CUSTOMER";
            cbCustomer.DisplayMember = "FULLNAME";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DataSource = db.getData(sql);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i >= 0)
            {   
                txtRentalID.Text = dataGridView1.Rows[i].Cells["RentalID"].Value.ToString();
                lbUser.SelectedValue = dataGridView1.Rows[i].Cells["UserID"].Value.ToString();
                cbCustomer.SelectedValue = dataGridView1.Rows[i].Cells["CustomerID"].Value.ToString();
                txtRentalDate.Text = dataGridView1.Rows[i].Cells["RentalDate"].Value.ToString();
                txtReturnDate.Text = dataGridView1.Rows[i].Cells["ReturnDate"].Value.ToString();
                txtDeposit.Text = dataGridView1.Rows[i].Cells["Deposit"].Value.ToString();
                txtDescription.Text = dataGridView1.Rows[i].Cells["Description"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtRentalID.Clear();
            txtRentalDate.Clear();
            txtReturnDate.Clear();
            txtDeposit.Clear();
            txtDescription.Clear();

            addNew = true;
            setEnable(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string us = lbUser.SelectedValue.ToString();
            string ct = cbCustomer.SelectedValue.ToString();
            string rd = txtRentalDate.Text;
            string re = txtReturnDate.Text;
            string dp = txtDeposit.Text;
            string des = txtDescription.Text;
            if (addNew) {
                string sql = "DECLARE @index INT;\n" +
                     "SELECT @index = SUBSTRING(MAX(RENTALID), 3, 2) + 1 FROM RENTAL;\n" +
                     $"INSERT INTO RENTAL VALUES (CONCAT('RT', @INDEX), N'{us}', N'{ct}',N'{rd}', N'{re}', N'{dp}', N'{des}')";
                DBServices db = new DBServices();
                db.runQuery(sql);
                getDataGridView();
            }
            else
            {
                string id = txtRentalID.Text;
                string sql = "UPDATE RENTAL SET " +
                    $"USERID = N'{us}', " +
                    $"CUSTOMERID = N'{ct}'," +
                    $"RENTALDATE = N'{rd}', " +
                    $"RETURNDATE = N'{re}', " +
                    $"DEPOSIT = N'{dp}', " +
                    $"DESCRIPTION = N'{des}' " +
                    $"WHERE RENTALID LIKE'{id}%'";
                addNew = true;
                setEnable(false);
                DBServices db = new DBServices();
                db.runQuery(sql);
                getDataGridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtRentalID.Text;
            string sql = $"DELETE FROM RENTAL WHERE RENTALID LIKE'{id}%'";
            if (MessageBox.Show("Bạn muốn xóa bản ghi này không???", "Thông báo!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                DBServices db = new DBServices();
                db.runQuery(sql);
                getDataGridView(); 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addNew= false;
            setEnable(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtRentalDate.Clear();
            txtDescription.Clear();
            txtReturnDate.Clear();
            txtDeposit.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRentalID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtRentalDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReturnDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
