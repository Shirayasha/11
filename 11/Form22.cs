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
    public partial class Form22 : Form
    {
        public Form22()
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
                DataRow nRow = main.testDataSet.Tables[1].NewRow();
                int rc = main.dataGridView4.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = dateTimePicker1.Value;
                nRow[2] = comboBox1.SelectedValue;
                main.testDataSet.Tables[1].Rows.Add(nRow);
                main.dogovorTableAdapter.Update(main.testDataSet.Dogovor);
                main.testDataSet.Tables[1].AcceptChanges();
                main.dataGridView4.Refresh();
            }
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Dogovor". При необходимости она может быть перемещена или удалена.
            this.dogovorTableAdapter.Fill(this.testDataSet.Dogovor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.testDataSet.Status);

        }
    }
}
