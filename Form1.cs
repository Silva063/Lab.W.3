using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW3._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Выбрана функция: sh(x)");
            else 
            
            if (radioButton2.Checked)
                MessageBox.Show("Выбрана функция: Math.Pow(x,2)");
            else

            if (radioButton3.Checked)
                MessageBox.Show("Выбрана функция: Math.Exp(x)");


        }

        double result;
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "x=" + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "y=" + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "z=" + z.ToString();

            if (radioButton1.Checked)
            {
                result = (Math.Abs(Math.Min(Math.Sinh(x), y) - Math.Max(y, z))) / (2d);
            }
            else if (radioButton2.Checked)
            {
                result = (Math.Abs(Math.Min(Math.Pow(x,2), y) - Math.Max(y, z))) / (2d);
            }
            else
            {
                result = (Math.Abs(Math.Min(Math.Exp(x), y) - Math.Max(y, z))) / (2d);
            }

            textBox4.Text+=Environment.NewLine + "Результат P = " + result.ToString();                
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


    }
}
