using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4_2
{
    public partial class Form2 : Form
    {
        public string txtb_value;
        int r = 174;
        int b = 126;

        public Form2(string type)
        {
            Button btn_close = new Button();
            btn_close.Location = new Point(r,b);
            btn_close.Name = "Close";
            btn_close.Click += Close_btn_click;
            btn_close.Text = "Close";

            InitializeComponent();

            this.Controls.Add(btn_close);

            if(type == "n")
            {
                button1.Text = "0";
                button2.Text = "1";
                button3.Text = "2";
                button4.Text = "3";
                button5.Text = "4";
                button6.Text = "5";
                button7.Text = "6";
                button8.Text = "7";
                button9.Text = "8";
                button10.Text = "9";
            }

            if (type == "l")
            {
                button1.Text = "а";
                button2.Text = "б";
                button3.Text = "в";
                button4.Text = "г";
                button5.Text = "д";
                button6.Text = "е";
                button7.Text = "ё";
                button8.Text = "ж";
                button9.Text = "з";
                button10.Text = "и";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text.ToString();
        }

        private void Close_btn_click(object sender, EventArgs e)
        {
            txtb_value = textBox1.Text.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
