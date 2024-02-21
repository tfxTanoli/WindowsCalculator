using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button11.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
           firstNumber = firstNumber + double.Parse(label1.Text);
            operation = "+";
            label1.Text = "";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(label1.Text);
            operation = "-";
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(label1.Text);
            operation = "x";
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(label1.Text);
            operation = "/";
            label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(label1.Text);
            if(operation == "+")
            {
                double result = firstNumber + secondNumber;
                label1.Text = result.ToString();
            }
            else if(operation == "-")
            {
                label1.Text = (firstNumber - secondNumber).ToString();
            }
            else if(operation == "x")
            {
                label1.Text = (firstNumber * secondNumber).ToString();
            }
            else if(operation == "/")
            {
                if (secondNumber != 0)
                {
                    label1.Text = (firstNumber / secondNumber).ToString();
                }
                else
                {
                    MessageBox.Show("Cannot Be Divided By Zero.");
                }
            }
            else if(operation == "x^y")
            {
                label1.Text = (Math.Pow(firstNumber, secondNumber)).ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(label1.Text);
            label1.Text = (firstNumber * firstNumber).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(label1.Text);
            double result = 1 / firstNumber;
            label1.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(label1.Text);
            double result = Math.Sqrt(firstNumber);
            label1.Text = result.ToString();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(label1.Text);
            operation = "x^y";
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }
    }
}
