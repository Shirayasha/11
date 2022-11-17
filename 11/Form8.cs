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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.testDataSet.Tables[0].NewRow();
                int rc = main.dataGridView3.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbMark.Text;
                nRow[2] = tbModel.Text;
                nRow[3] = tbYear.Text;
                nRow[4] = tbCost.Text;
                nRow[5] = comboBox1.SelectedValue;
                main.testDataSet.Tables[0].Rows.Add(nRow);
                main.avtomobilTableAdapter.Update(main.testDataSet.Avtomobil);
                main.testDataSet.Tables[0].AcceptChanges();
                main.dataGridView3.Refresh();
                tbMark.Text = "";
                tbModel.Text = "";
                tbYear.Text = "";
                tbCost.Text = "";
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Avtomobil". При необходимости она может быть перемещена или удалена.
            this.avtomobilTableAdapter.Fill(this.testDataSet.Avtomobil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Tip_avtomobilya". При необходимости она может быть перемещена или удалена.
            this.tip_avtomobilyaTableAdapter.Fill(this.testDataSet.Tip_avtomobilya);

        }
    }
}
