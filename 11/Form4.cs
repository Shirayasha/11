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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.testDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Dolznost". При необходимости она может быть перемещена или удалена.
            this.dolznostTableAdapter.Fill(this.testDataSet.Dolznost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Otdel_bughalterii". При необходимости она может быть перемещена или удалена.
            this.otdel_bughalteriiTableAdapter.Fill(this.testDataSet.Otdel_bughalterii);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 sf = new Form7();
            sf.Owner = this;
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 sf = new Form11();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            otdelbughalteriiBindingSource.EndEdit();
            otdel_bughalteriiTableAdapter.Update(testDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 sf = new Form12();
            sf.Owner = this;
            sf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 sf = new Form13();
            sf.Owner = this;
            sf.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dolznostBindingSource.EndEdit();
            dolznostTableAdapter.Update(testDataSet);
        }
    }
}
