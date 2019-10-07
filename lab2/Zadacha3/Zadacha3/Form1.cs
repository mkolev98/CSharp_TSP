using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //function for convert 
        public double m_unitConvert(string from_unit, string to_unit, double x){
            double result = 0;
            if(from_unit == "feet" && to_unit == "yards")
            {
               result = x / 3;
            }else if(from_unit == "feet" && to_unit == "inches")
            {
                result = x * 12;
            }else if(from_unit == "feet" && to_unit == "miles")
            {
                result = x / 5280.0;
            }else if(from_unit == "yards" && to_unit == "feet")
            {
                result = x * 3;
            }
            else if (from_unit == "yards" && to_unit == "inches")
            {
                result = x * 36;
            }
            else if (from_unit == "yards" && to_unit == "miles")
            {
                result = x * 0.000568; 
            }
            else if (from_unit == "inches" && to_unit == "feet")
            {
                result = x * 0.0833333333; ;
            }
            else if (from_unit == "inches" && to_unit == "yards")
            {
                result = x/ 36;
            }
            else if (from_unit == "inches" && to_unit == "miles")
            {
                result = x / 63360;
            }
            else if (from_unit == "miles" && to_unit == "feet")
            {
                result = x* 5280.0;
            }
            else if (from_unit == "miles" && to_unit == "yards")
            {
                result = x * 1760;
            }
            else if (from_unit == "miles" && to_unit == "inches")
            {
                result = x * 63360;
            }

            return result;

            }
       

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
            double a = Double.Parse(inputBox.Text);
            resultBox.Text = m_unitConvert(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), a).ToString();
            }catch{
                MessageBox.Show("Populnete poletata!");
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            inputBox.Clear();
            resultBox.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
