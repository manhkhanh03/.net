using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTBN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void a_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            if (a.Text == "0" && b.Text == "0")
            {
                result.Text = "Phương trình vô số nghiệm!!!!";
            }else if( a.Text == "0" && b.Text != "0")
            {
                result.Text = "Phương trình vô nghiệm!!!";
            }else
            {
                double numberA = Convert.ToDouble(a.Text);
                double numberB = Convert.ToDouble(b.Text);
                numberB *= -1;
                double hideX = numberB / numberA;
                result.Text = hideX.ToString();
            }
        }

        private void count_Click(object sender, EventArgs e)
        {
            result_TextChanged(sender, e);
        }

        private void del_Click(object sender, EventArgs e)
        {
            result.Clear();
            a.Clear();
            b.Clear();
        }
    }
}
