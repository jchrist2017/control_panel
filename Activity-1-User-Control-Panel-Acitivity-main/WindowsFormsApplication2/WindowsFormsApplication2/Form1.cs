using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string panelOneInputOne
        {
            set
            {
                textBox1.Text = value;
            }
        }

        public string panelOneInputTwo
        {
            set
            {
                textBox2.Text = value;
            }
        }

        public string panelTwoInputOne
        {
            set
            {
                textBox1.Text = value;
            }
        }

        public string panelTwoInputTwo
        {
            set
            {
                textBox2.Text = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();

            userControl11.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();

            userControl21.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();

            userControl11.Hide();

        }
    }
}
