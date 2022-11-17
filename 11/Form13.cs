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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main.testDataSet.Tables[2].NewRow();
                int rc = main.dataGridView2.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbDolz.Text;
                main.testDataSet.Tables[2].Rows.Add(nRow);
                main.dolznostTableAdapter.Update(main.testDataSet.Dolznost);
                main.testDataSet.Tables[2].AcceptChanges();
                main.dataGridView2.Refresh();
                tbDolz.Text = "";
            }
        }
    }
}
