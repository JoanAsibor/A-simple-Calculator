﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = string.Empty;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1=Convert.ToInt32(textBox1.Text);
            int number2=Convert.ToInt32(textBox2.Text);
            int sum=number1+number2;
            label4.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1= Convert.ToInt32(textBox1.Text);
            int number2= Convert.ToInt32(textBox2.Text);
            int difference=number1-number2;
            label4.Text = difference.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2= Convert.ToInt32(textBox2.Text);
            int multiply=number1*number2;
            label4.Text = multiply.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1= Convert.ToInt32(textBox1.Text);
            int number2= Convert.ToInt32(textBox2.Text);
            int divide=number1/number2;
            label4.Text = divide.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number1= Convert.ToInt32(textBox1.Text);
            int number2= Convert.ToInt32(textBox2.Text);
            int modulus=number1%number2; 
            label4.Text = modulus.ToString();
        }
    }
}
