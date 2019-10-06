using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double FahrToCel(double x)
        {
            double result = (x - 32) / 1.8000;

            return result;
        }

        public double CelToFahr(double x)
        {
            double result = (x * 9/5) + 32;
            return result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double val = Double.Parse(textBox1.Text);
           
            if (comboBox1.SelectedIndex.Equals(0))
            {
                textBox_res.Text = Math.Round((FahrToCel(Double.Parse(textBox1.Text))),2).ToString();
                label3.Text = val.ToString() + " From F to C : ";
            }
            else if (comboBox1.SelectedIndex.Equals(1))
            {
                textBox_res.Text = Math.Round((CelToFahr(Double.Parse(textBox1.Text))), 2).ToString();
                label3.Text = val.ToString() + " From C to F : ";
            }
        }
    }
}
