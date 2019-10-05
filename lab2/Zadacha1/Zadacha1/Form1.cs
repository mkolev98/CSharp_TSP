using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double a, b, c, disc, x1, x2;
            a = Double.Parse(textBoxA.Text);
            b = Double.Parse(textBoxB.Text);
            c = Double.Parse(textBoxC.Text);

            if(a != 0)
            {
                disc = b * b - 4 * a * c;
                disc_label.Text = disc.ToString();

                if (disc < 0)
                {

                    x1_result.Text = "Nqma realni koreni.";
                    x2_result.Text = "Nqma realni koreni.";

                }
                else if (disc > 0)
                {

                    x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                    x2 = (-b - Math.Sqrt(disc)) / (2 * a);

                    x1_result.Text = x1.ToString();
                    x2_result.Text = x2.ToString();

                }
                else if (disc == 0)
                {
                    x1 = -b / (2 * a);
                    x1_result.Text = x1.ToString();

                }
            }
            else
            {
                MessageBox.Show("a ne moje da e 0");
            }
            
        }
    }
}
