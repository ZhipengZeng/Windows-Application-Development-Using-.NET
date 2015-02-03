using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number1, number2;
            double pro, sum, avg, max, min;
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            pro = number1 * number2;
            sum = number1 + number2;
            avg = sum / 2;
            if (number2 > number1)
            {
                max = number2;
                min = number1;
            }
            else
            {
                max = number1;
                min = number2;
            }
            MessageBox.Show("Pro: " + pro + "\nSum: " + sum + "\nAvg: " + avg + "\nMax: " + max + "\nMin: " + min);
                

        }

        
    }
}
