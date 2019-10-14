using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            yourChoice(a, b);

        }

        private void yourChoice(double a, double b)
        {
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                double res = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
                textBox3.Text = res.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                double res = Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2);
                textBox3.Text = res.ToString();
            }
            else if (radioButton3.Checked == true)
            {
                double res = Math.Pow(a, 2) - Math.Pow(b, 2);
                textBox3.Text = res.ToString();

            }
            else if (radioButton4.Checked == true)
            {
                double res = Math.Pow(a, 3) + 3 * Math.Pow(a, 2) * b + 3 * a * Math.Pow(b, 2) + Math.Pow(b, 3);
                textBox3.Text = res.ToString();
            }
            else if (radioButton5.Checked == true)
            {
                double res = Math.Pow(a, 3) - 3 * Math.Pow(a, 2) * b + 3 * a * Math.Pow(b, 2) - Math.Pow(b, 3);
                textBox3.Text = res.ToString();
            }
            else if (radioButton6.Checked == true)
            {
                double res = (a + b) * (Math.Pow(a, 2) - a * b + Math.Pow(b, 2));
                textBox3.Text = res.ToString();
            }
            else if (radioButton7.Checked == true)
            {
                double res = (a - b) * (Math.Pow(a, 2) + a * b + Math.Pow(b, 2));
                textBox3.Text = res.ToString();
            }
        }
    }
}
