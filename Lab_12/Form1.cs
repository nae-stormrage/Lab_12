using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_12
{
    public partial class Form1 : Form
    {
        string arg01;
        string arg02;
        string arg03;
        string arg04;
        string arg05;
        double RES;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = (e.X).ToString();
            textBox2.Text = (e.Y).ToString();
            arg01 = textBox1.Text;
            arg02 = textBox2.Text;
            arg03 = textBox3.Text;
            arg04 = textBox4.Text;
            arg05 = textBox5.Text;
            try
            {
                double c_arg01 = Convert.ToDouble(arg01);
                double c_arg02 = Convert.ToDouble(arg02);
                double c_arg03 = Convert.ToDouble(arg03);
                double c_arg04 = Convert.ToDouble(arg04);
                double c_arg05 = Convert.ToDouble(arg05);
                RES = (c_arg01 - c_arg02 + Math.Abs(Math.Sin(c_arg03) + Math.Sqrt(Math.Abs(c_arg04))))/(Math.Pow(c_arg01, c_arg05) - Math.Log10(c_arg02));
                Text = ("RES = " + RES.ToString());
            } catch
            {
                Text = string.Format("ERROR");
            }
        }
    }
}