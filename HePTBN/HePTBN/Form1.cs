using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void countPTBN()
        {
            double a1 = Convert.ToDouble(textBox1.Text);
            double b1 = Convert.ToDouble(textBox2.Text);
            double c1 = Convert.ToDouble(textBox3.Text);
            double a2 = Convert.ToDouble(textBox4.Text);
            double b2 = Convert.ToDouble(textBox5.Text);
            double c2 = Convert.ToDouble(textBox6.Text);
            double y, x;
            // chuyen ve pt 2
            a2 = a2 * -1;
            if(b2 < 0)
            {
                b2 = b2 * -1;
                a2 = a2 * -1;
                c2 = c2 * -1;
            }

            //  the lan 1
            double b3 = b1 * b2;
            b3 = b3 * a2;
            double c3 = b3 * c2;
            a1 = a1 * b3;
            c3 = c1 - c3;
            // the lan 2
            x = c3 / a1;
            double a3 = a2 * x;
            y = (a3 + c2) / b2;

            textBox7.Text = "x = " + x.ToString() + "\ty = " + y.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            countPTBN();
        }

        private void count_Click(object sender, EventArgs e)
        {
            textBox7_TextChanged(sender, e);
        }
    }
}
