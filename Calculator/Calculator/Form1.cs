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
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Calcu(object sender, EventArgs e)
        {
            double var1, var2;
            string s = (sender as Button).Text;
            try
            {
                var1 = Double.Parse(textBox1.Text);
                var2 = Double.Parse(textBox2.Text);


                if (s == "+")
                {
                    textBox3.Text = Calc.addNumbers(var1, var2).ToString();
                }
                else if (s == "-")
                {
                    textBox3.Text = Calc.subNumbers(var1, var2).ToString();
                }
                else if (s == "x")
                {
                    textBox3.Text = Calc.multNumbers(var1, var2).ToString();
                }
                else if (s == "/")
                {
                    textBox3.Text = Calc.divNumbers(var1, var2).ToString();
                }

            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        Calculator Calc = new Calculator();

        private void button1_Click(object sender, EventArgs e)
        {
            Calcu(sender, e);
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            Calcu(sender, e);
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            Calcu(sender, e);
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            Calcu(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double var1 = double.Parse(textBox1.Text);
                double var2 = double.Parse(textBox2.Text);
                if (comboBox1.Text == "Add")
                {
                    textBox3.Text = Calc.addNumbers(var1, var2).ToString();
                }
                else if (comboBox1.Text == "Subtract")
                {
                    textBox3.Text = Calc.subNumbers(var1, var2).ToString();
                }
                else if (comboBox1.Text == "Multiply")
                {
                    textBox3.Text = Calc.multNumbers(var1, var2).ToString();
                }
                else if (comboBox1.Text == "Divide")
                {
                    textBox3.Text = Calc.divNumbers(var1, var2).ToString();
                }

            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}

