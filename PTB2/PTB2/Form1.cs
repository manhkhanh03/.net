using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void output(int a) { 
            if(a == 0)
            {
                result.Text = "PT vo nghiem!!!";
            }else
            {
                result.Text = "PT vo so nghiem!!!";
            }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            if (a.Text == "0" && b.Text == "0")
                output(1);
            else if (a.Text == "0" && b.Text != "0")
                output(0);
            else
            {
                double numberA = Convert.ToDouble(a.Text);
                double numberB = Convert.ToDouble(b.Text);
                double numberC = Convert.ToDouble(c.Text);
                double delta = Math.Pow(numberB, 2) - (4 * numberA * numberC);
                if (delta < 0)
                   output(0);
                else if (delta == 0) 
                    result.Text = "x1 = x2 = " + (numberB * -1) / (2 * numberA);
                else
                {
                    double x1 = (-numberB - Math.Sqrt(delta)) / (2 * numberA);
                    double x2 = (-numberB + Math.Sqrt(delta)) / (2 * numberA);   
                    result.Text = "x1: " + x1.ToString() + " - x2: " + x2.ToString();
                }
            }
        }

        private void count_Click(object sender, EventArgs e)
        {
            result_TextChanged(sender, e);
        }

        private void del_Click(object sender, EventArgs e)
        {
            a.Clear();
            b.Clear();
            c.Clear();
            result.Clear();
        }

        private void a_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
