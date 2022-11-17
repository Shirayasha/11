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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.testDataSet.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Dogovor". При необходимости она может быть перемещена или удалена.
            this.dogovorTableAdapter.Fill(this.testDataSet.Dogovor);

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
                DataRow nRow = main.testDataSet.Tables[3].NewRow();
                int rc = main.dataGridView3.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbFam.Text;
                nRow[2] = tbIm.Text;
                nRow[3] = tbOtch.Text;
                nRow[4] = tbPasp.Text;
                nRow[5] = dateTimePicker1.Value;
                nRow[6] = comboBox1.SelectedValue;
                main.testDataSet.Tables[3].Rows.Add(nRow);
                main.klientTableAdapter.Update(main.testDataSet.Klient);
                main.testDataSet.Tables[3].AcceptChanges();
                main.dataGridView3.Refresh();
                tbFam.Text = "";
                tbIm.Text = "";
                tbOtch.Text = "";
                tbPasp.Text = "";
            }
        }
    }
}
