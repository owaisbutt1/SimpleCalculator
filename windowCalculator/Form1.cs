using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double sum = num1 - num2;
                label2.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("please enter valid numbers");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double sum = num1 + num2;
                label2.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("please enter valid numbers");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                if(num2 == 0)
                {
                    MessageBox.Show("Can't Divided by Zero");
                }
                else
                { 
                    double Divide = num1 / num2;
                    label2.Text = Divide.ToString();
                }
            }
            else
            {
                MessageBox.Show("please enter valid numbers");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double MULTIPLY = num1 * num2;
                label2.Text = MULTIPLY.ToString();
            }
            else
            {
                MessageBox.Show("please enter valid numbers");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double MOD = num1 % num2;
                label2.Text = MOD.ToString();
            }
            else
            {
                MessageBox.Show("please enter valid numbers");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double POWER = Math.Pow(num1, num2);
                label2.Text = POWER.ToString();
            }
            else
            {
                MessageBox.Show("please enter valid numbers");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double sub = num1 - num2;
                label2.Text = sub.ToString();
            }
            else
            {
                MessageBox.Show("please enter valid numbers");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
