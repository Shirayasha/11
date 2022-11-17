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
    public partial class AddForm2 : Form
    {
        public AddForm2()
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
                DataRow nRow = main.testDataSet.Tables[9].NewRow();
                int rc = main.dataGridView2.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbOklad.Text;
                nRow[2] = tbFam.Text;
                nRow[3] = tbIm.Text;
                nRow[4] = tbOtch.Text;
                nRow[5] = tbPasp.Text;
                nRow[6] = comboBox1.SelectedValue;
                nRow[7] = comboBox2.SelectedValue;
                main.testDataSet.Tables[9].Rows.Add(nRow);
                main.sotrudnikTableAdapter.Update(main.testDataSet.Sotrudnik);
                main.testDataSet.Tables[9].AcceptChanges();
                main.dataGridView2.Refresh();
                tbOklad.Text = "";
                tbFam.Text = "";
                tbIm.Text = "";
                tbOtch.Text = "";
                tbPasp.Text = "";
            }
        }

        private void AddForm2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Dolznost". При необходимости она может быть перемещена или удалена.
            this.dolznostTableAdapter.Fill(this.testDataSet.Dolznost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.testDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Pol". При необходимости она может быть перемещена или удалена.
            this.polTableAdapter.Fill(this.testDataSet.Pol);

        }

    }
}
