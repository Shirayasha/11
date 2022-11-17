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
    public partial class AddForm3 : Form
    {
        public AddForm3()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Avtomobil". При необходимости она может быть перемещена или удалена.
            this.avtomobilTableAdapter.Fill(this.testDataSet.Avtomobil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Zakupka_avtomobiley". При необходимости она может быть перемещена или удалена.
            this.zakupka_avtomobileyTableAdapter.Fill(this.testDataSet.Zakupka_avtomobiley);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.testDataSet.Sotrudnik);

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
                DataRow nRow = main.testDataSet.Tables[12].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbStoimost.Text;
                nRow[2] = tbGod.Text;
                nRow[3] = comboBox1.SelectedValue;
                nRow[4] = comboBox2.SelectedValue;
                main.testDataSet.Tables[12].Rows.Add(nRow);
                main.zakupka_avtomobileyTableAdapter.Update(main.testDataSet.Zakupka_avtomobiley);
                main.testDataSet.Tables[12].AcceptChanges();
                main.dataGridView1.Refresh();
                tbStoimost.Text = "";
                tbGod.Text = "";
            }
        }

        private void tbStoimost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
