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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            text_a.Clear();
            text_b.Clear();
            text_c.Clear();
            text_D.Clear();
            text_x1.Clear();
            text_x2.Clear();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double a, b, c, disc, x1, x2;
            a = Double.Parse(text_a.Text);
            b = Double.Parse(text_b.Text);
            c = Double.Parse(text_c.Text);

            if (a != 0)
            {
                disc = b * b - 4 * a * c;
                text_D.Text = disc.ToString();

                if (disc < 0)
                {

                    text_x1.Text = "Nqma realni koreni.";
                    text_x2.Text = "Nqma realni koreni.";

                }
                else if (disc > 0)
                {

                    x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                    x2 = (-b - Math.Sqrt(disc)) / (2 * a);

                    text_x1.Text = x1.ToString();
                    text_x2.Text = x2.ToString();

                }
                else if (disc == 0)
                {
                    x1 = -b / (2 * a);
                    text_x1.Text = x1.ToString();

                }
            }
            else
            {
                MessageBox.Show("a ne moje da e 0");
            }

        }
    }
    }
