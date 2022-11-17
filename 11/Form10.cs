using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 sf = new Form1();
            sf.Owner = this;
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 sf = new Form4();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form14 sf = new Form14();
            sf.Owner = this;
            sf.Show();
        }
    }
}
