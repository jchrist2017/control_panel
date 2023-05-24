using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputOne = this.textBox1.Text;
            var inputTwo = this.textBox2.Text;

            var parent = this.Parent as Form1;

            parent.panelOneInputOne = inputOne;
            parent.panelOneInputTwo = inputTwo;
        }
    }
}
