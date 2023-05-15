using Microsoft.Reporting.WinForms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, EventArgs e)
        {
            frmUserLINQ uslq = new frmUserLINQ();  
            uslq.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BOOKRENTALEntities myBook = new BOOKRENTALEntities();
            ReportDataSource rds = new ReportDataSource("DataSet1", myBook.Users);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

        public void ManhKhanh()
        {

        }
    }
}
