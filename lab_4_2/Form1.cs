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
    public partial class Form1 : Form
    {
        public TextBox textBox1 = new TextBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var ff = new Form2("n"))
            {
                var res = ff.ShowDialog();
                if (res == DialogResult.OK)
                {
                    textBox1.Location = new Point(12, 12);
                    textBox1.Width = 218;
                    textBox1.Height = 20;
                    textBox1.Text = ff.txtb_value;

                    this.Controls.Add(textBox1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var ff = new Form2("l"))
            {
                var res = ff.ShowDialog();
                if (res == DialogResult.OK)
                {
                    textBox1.Location = new Point(12, 12);
                    textBox1.Width = 218;
                    textBox1.Height = 20;
                    textBox1.Text = ff.txtb_value;

                    this.Controls.Add(textBox1);
                }
            }
        }
    }
}
