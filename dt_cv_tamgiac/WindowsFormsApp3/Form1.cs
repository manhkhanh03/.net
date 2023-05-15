using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private double ab = 0, bc = 0, ac = 0, x1 = 0, x2 = 0, x3 = 0, y1 = 0, y2 = 0, y3 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void count_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(Point_x1.Text);
            x2 = Convert.ToDouble(Point_x2.Text);
            x3 = Convert.ToDouble(Point_x3.Text);
            y1 = Convert.ToDouble(Point_y1.Text);
            y2 = Convert.ToDouble(Point_y2.Text);
            y3 = Convert.ToDouble(Point_y3.Text);

            kq_chuvi_TextChanged(sender, e);
            kq_dienTich_TextChanged(sender, e);
        }

        private void Point_x1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kq_dienTich_TextChanged(object sender, EventArgs e)
        {
            double bac = Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)) / 2;
            kq_dienTich.Text = bac.ToString();
        }

        private void Point_y1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Point_x2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Point_y2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Point_x3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Point_y3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kq_chuvi_TextChanged(object sender, EventArgs e)
        {
            ab = Math.Abs(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            bc = Math.Abs(Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)));
            ac = Math.Abs(Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)));
            double chuVi = Math.Abs(ab + bc + ac);
            kq_chuvi.Text = chuVi.ToString();
        }

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Point_x1.Clear();
            Point_x2.Clear();
            Point_x3.Clear();
            Point_y1.Clear();
            Point_y2.Clear();
            Point_y3.Clear();
            kq_chuvi.Clear();
            kq_dienTich.Clear();
        }
    }
}
