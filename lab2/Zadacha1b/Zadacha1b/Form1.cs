using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha1b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /*   public void textBoxC_Leave(object sender, System.EventArgs e)
           {
               MessageBox.Show("focus lost");
           }*/
        private void Disc(double a, double b, double c)
        {
            double disc = Math.Pow(b, 2) - 4*a*c;
            double x1, x2;

            if (a == 0)
            {
                MessageBox.Show(" 'а' трябва да бъде различно от нула", "Задача 1");
            }
            else
            {

                if (disc == 0)
                {
                    x1 = -b / (2 * a);
                    x1_result.Text = x1.ToString();
                    //x2_result.Text = x2.ToString();

                }
                else if (disc > 0)
                {
                    x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                    x2 = (-b - Math.Sqrt(disc)) / (2 * a);

                    x1_result.Text = x1.ToString();
                    x2_result.Text = x2.ToString();
                }
                else
                {
                    x1_result.Text = "Няма реални корени";
                    x2_result.Text = "Няма реални корени";
                }
            }
        }
        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            double value1, value2, value3;
            try
            {
                value1 = Double.Parse(textBoxA.Text);
                value2 = Double.Parse(textBoxB.Text);
                value3 = Double.Parse(textBoxC.Text);

                Disc(value1, value2, value3);
            }
            catch
            {
                //MessageBox.Show("Molq vuvedete validni stoinosti!");
            }
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

            double value1, value2, value3;
            try
            {
                value1 = Double.Parse(textBoxA.Text);
                value2 = Double.Parse(textBoxB.Text);
                value3 = Double.Parse(textBoxC.Text);

                Disc(value1, value2, value3);
            }
            catch
            {
               // MessageBox.Show("Molq vuvedete validni stoinosti!");
            }
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

            double value1, value2, value3;
            try
            {
                value1 = Double.Parse(textBoxA.Text);
                value2 = Double.Parse(textBoxB.Text);
                value3 = Double.Parse(textBoxC.Text);

                Disc(value1, value2, value3);
            }
            catch
            {
          
               // MessageBox.Show("Molq vuvedete validni stoinosti!");
            }
        }
    }
}
    




