using System;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b, c;
        char znak;
        bool d;
        void button22_Click(object sender, EventArgs e)
        {
            if (d)
            {
                d = false;
                textBox1.Text = "";
                textBox1.Tag = "";
            }
            textBox1.Text += (sender as Button).Text;
        }

        void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        void button24_Click(object sender, EventArgs e)
        {
            d = true;
            b = Convert.ToDouble(textBox1.Text);
            if (znak == '+')
                c = a + b;
            else if (znak == '-')
                c = a - b;
            else if (znak == '×')
                c = a * b;
            else if (znak == '÷')
                c = a / b;
            else if (znak == '%')
                c = a * b / 100;
            textBox1.Text = c.ToString();
        }

        void button23_Click(object sender, EventArgs e)
        {
            d = false;
            if (!textBox1.Text.Contains(","))
                textBox1.Text += ",";
        }

        double k = 0, r = 0;
        void button2_Click(object sender, EventArgs e)
        {
            d = true;
            k = Convert.ToDouble(textBox1.Text);
            r = Math.Sqrt(k);
            textBox1.Text = r.ToString();
        }

        void button3_Click(object sender, EventArgs e)
        {
            d = true;
            k = Convert.ToDouble(textBox1.Text);
            r = Math.Pow(k, 2);
            textBox1.Text = r.ToString();
        }

        void button4_Click(object sender, EventArgs e)
        {
            d = true;
            k = Convert.ToDouble(textBox1.Text);
            r = 1 / k;
            textBox1.Text = r.ToString();
        }

        void button21_Click(object sender, EventArgs e)
        {
            k = Convert.ToDouble(textBox1.Text);
            r = -k;
            textBox1.Text = r.ToString();
        }

        void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}