using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zgadywanieliczb
{
    public partial class Form1 : Form
    {
        int nrPr = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int los = 0;
            Random rand = new Random();
            if (radioButton1.Checked)

                los = rand.Next(0, 1000);
            else if (radioButton2.Checked)
                los = rand.Next(0, 100);
            else
                los = rand.Next(0, 10);
           
            textBox1.Text = "1";
            textBox2.Clear();
            button1.Enabled = false;
            panel2.BackColor = Control.DefaultBackColor;
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nrPr++;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
