using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string sign;
        double value1 = 0;
        double value2 = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        void clearSign()
        {
            if(result.Text == sign)
            {
                result.Clear();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            clearSign();
            result.Text += btn1.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            clearSign();
            result.Text += btn0.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clearSign();
            result.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            clearSign();
            result.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clearSign();
            result.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            clearSign();
            result.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            clearSign();
            result.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            clearSign();
            result.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            clearSign();
            result.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            clearSign();
            result.Text += btn9.Text;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            result.Clear();
            value1 = 0;
            value2 = 0;
            sign = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sign = "+";
            if (result.Text != "+" && result.Text != "-" && result.Text != "*" && result.Text != "/" && result.Text != "")
                value1 = double.Parse(result.Text);
            result.Text = sign;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double valueResult = 0;
            if (result.Text != "+" && result.Text != "-" && result.Text != "*" && result.Text != "/" && result.Text != "" && sign != "")
                value2 = double.Parse(result.Text);
            switch (sign)
            {
                case "+":
                    valueResult = value1 + value2;
                    break;
                case "-":
                    valueResult = value1 - value2;
                    break;
                case "*":
                    valueResult = value1 * value2;
                    break;
                case "/":
                    valueResult = value1 / value2;
                    break;
                default:
                    valueResult = Math.Sqrt(value1);
                    break;
            }
            result.Text = valueResult.ToString();
        }

        void assignValue()
        {
            if (result.Text != "+" && result.Text != "-" && result.Text != "*" && result.Text != "/" && result.Text != "")
                value1 = double.Parse(result.Text);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            sign = "-";
            assignValue();
            result.Text = sign;
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            sign = "*";
            assignValue();
            result.Text = sign;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            sign = "/";
            assignValue();
            result.Text = sign;
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            sign = "";
            assignValue();
            Console.WriteLine(value1);
            result.Text = "Sqrt(" + result.Text + ")";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            result.Text += btnDot.Text;
        }
    }
}
