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
    public partial class Form1 : Form
    {

        string input; //user input
        string operand; //first operator
        string operand2; //second operator
        char operation; //char for operation
        double result; //result



        public Form1()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += "0";
            this.Calc.Text += input;
        }

        private void Calc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                Calc.Text = result.ToString();
            }

            else if (operation == '-')
            {
                result = num1 - num2;
                Calc.Text = result.ToString();
            }

            else if (operation == '*')
            {
                result = num1 * num2;
                Calc.Text = result.ToString();
            }

            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Calc.Text = result.ToString();
                }
                else
                {
                    Calc.Text = "Cannot divide by zero";
                }
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operand = input;
            operation = '/';
            input = string.Empty;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += ".";
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += "1";
            this.Calc.Text += input;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            this.input = string.Empty;
            this.operand = string.Empty;
            this.operand2 = string.Empty;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += "2";
            this.Calc.Text += input;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += "3";
            this.Calc.Text += input;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += "4";
            this.Calc.Text += input;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += "5";
            this.Calc.Text += input;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += "6";
            this.Calc.Text += input;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += "7";
            this.Calc.Text += input;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += "8";
            this.Calc.Text += input;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.Calc.Text = "";
            input += "9";
            this.Calc.Text += input;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            operand = input;
            operation = '+';
            input = string.Empty;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            operand = input;
            operation = '-';
            input = string.Empty;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            operand = input;
            operation = '*';
            input = string.Empty;
        }
    }
}
