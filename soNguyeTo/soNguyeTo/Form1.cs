using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soNguyeTo
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(input.Text);
            int[] arr = new int[n];
            int j = 0;
            for (int i = 2; i <= n; i++)
            {
                if(i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    arr[j++] = i;
                }else if(i == 2 || i == 3)
                {
                    arr[j++] = i;
                }
            }
            for (int i = 0; i < j; i++)
            {
                output.Text = arr[i].ToString();
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void del_Click(object sender, EventArgs e)
        {
            input.Clear();
            output.Clear();
        }
    }
}
