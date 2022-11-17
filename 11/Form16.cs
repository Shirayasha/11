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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.testDataSet.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Mekhanik". При необходимости она может быть перемещена или удалена.
            this.mekhanikTableAdapter.Fill(this.testDataSet.Mekhanik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Avtomobil". При необходимости она может быть перемещена или удалена.
            this.avtomobilTableAdapter.Fill(this.testDataSet.Avtomobil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Remont_avtomobiley". При необходимости она может быть перемещена или удалена.
            this.remont_avtomobileyTableAdapter.Fill(this.testDataSet.Remont_avtomobiley);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Remont". При необходимости она может быть перемещена или удалена.
            this.remontTableAdapter.Fill(this.testDataSet.Remont);

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
                DataRow nRow = main.testDataSet.Tables[8].NewRow();
                int rc = main.dataGridView1.RowCount + 0;
                nRow[0] = rc;
                nRow[1] = dateTimePicker1.Value;
                nRow[2] = tbStoim.Text;
                nRow[3] = comboBox1.SelectedValue;
                nRow[4] = comboBox2.SelectedValue;
                nRow[5] = comboBox3.SelectedValue;
                nRow[6] = comboBox4.SelectedValue;
                main.testDataSet.Tables[8].Rows.Add(nRow);
                main.remont_avtomobileyTableAdapter.Update(main.testDataSet.Remont_avtomobiley);
                main.testDataSet.Tables[8].AcceptChanges();
                main.dataGridView1.Refresh();
                tbStoim.Text = "";
            }
        }
    }
}
