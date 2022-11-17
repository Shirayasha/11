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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.testDataSet.Status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Mekhanik". При необходимости она может быть перемещена или удалена.
            this.mekhanikTableAdapter.Fill(this.testDataSet.Mekhanik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Avtomobil". При необходимости она может быть перемещена или удалена.
            this.avtomobilTableAdapter.Fill(this.testDataSet.Avtomobil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Remont". При необходимости она может быть перемещена или удалена.
            this.remontTableAdapter.Fill(this.testDataSet.Remont);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Dogovor". При необходимости она может быть перемещена или удалена.
            this.dogovorTableAdapter.Fill(this.testDataSet.Dogovor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.testDataSet.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Mekhanik". При необходимости она может быть перемещена или удалена.
            this.mekhanikTableAdapter.Fill(this.testDataSet.Mekhanik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Remont_avtomobiley". При необходимости она может быть перемещена или удалена.
            this.remont_avtomobileyTableAdapter.Fill(this.testDataSet.Remont_avtomobiley);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 af = new Form15();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 af = new Form16();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            remontavtomobileyBindingSource.EndEdit();
            remont_avtomobileyTableAdapter.Update(testDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form17 af = new Form17();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            mekhanikBindingSource.EndEdit();
            mekhanikTableAdapter.Update(testDataSet);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form18 af = new Form18();
            af.Owner = this;
            af.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            klientBindingSource.EndEdit();
            klientTableAdapter.Update(testDataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form19 af = new Form19();
            af.Owner = this;
            af.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form20 af = new Form20();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView4_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dogovorBindingSource.EndEdit();
            dogovorTableAdapter.Update(testDataSet);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form21 af = new Form21();
            af.Owner = this;
            af.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form22 af = new Form22();
            af.Owner = this;
            af.Show();
        }
    }
}
