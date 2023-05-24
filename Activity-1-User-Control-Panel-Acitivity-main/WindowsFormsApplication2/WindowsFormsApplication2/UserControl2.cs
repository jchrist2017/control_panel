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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputOne = this.textBox1.Text;
            var inputTwo = this.textBox2.Text;

            var parent = this.Parent as Form1;

            parent.panelTwoInputOne = inputOne;
            parent.panelTwoInputTwo = inputTwo;
        }
    }
}
