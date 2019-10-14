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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double n = Double.Parse(textBox2.Text);
            textBox3.Text = Math.Pow(a, n).ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btn_glavno_Click(object sender, EventArgs e)
        {
            
        }
    }
}
