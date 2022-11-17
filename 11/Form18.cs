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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 main = this.Owner as Form14;
            if (main != null)
            {
                DataRow nRow = main.testDataSet.Tables[4].NewRow();
                int rc = main.dataGridView2.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbFam.Text;
                nRow[2] = tbIm.Text;
                nRow[3] = tbOtch.Text;
                nRow[4] = tbStazh.Text;
                nRow[5] = tbOklad.Text;
                nRow[6] = tbPasp.Text;
                nRow[7] = dateTimePicker1.Value;
                main.testDataSet.Tables[4].Rows.Add(nRow);
                main.mekhanikTableAdapter.Update(main.testDataSet.Mekhanik);
                main.testDataSet.Tables[4].AcceptChanges();
                main.dataGridView2.Refresh();
                tbFam.Text = "";
                tbIm.Text = "";
                tbOtch.Text = "";
                tbStazh.Text = "";
                tbOklad.Text = "";
                tbPasp.Text = "";
            }
        }
    }
}
