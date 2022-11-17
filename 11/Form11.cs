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
    public partial class Form11 : Form
    {
        public Form11()
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
                DataRow nRow = main.testDataSet.Tables[5].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = tbPrem.Text;
                nRow[2] = tbShtraf.Text;
                nRow[3] = tbItog.Text;
                nRow[4] = comboBox1.SelectedValue;
                nRow[5] = comboBox2.SelectedValue;
                main.testDataSet.Tables[5].Rows.Add(nRow);
                main.otdel_bughalteriiTableAdapter.Update(main.testDataSet.Otdel_bughalterii);
                main.testDataSet.Tables[5].AcceptChanges();
                main.dataGridView1.Refresh();
                tbPrem.Text = "";
                tbShtraf.Text = "";
                tbItog.Text = "";
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.testDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Otdel_bughalterii". При необходимости она может быть перемещена или удалена.
            this.otdel_bughalteriiTableAdapter.Fill(this.testDataSet.Otdel_bughalterii);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Dolznost". При необходимости она может быть перемещена или удалена.
            this.dolznostTableAdapter.Fill(this.testDataSet.Dolznost);

        }
    }
}
