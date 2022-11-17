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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Tip_avtomobilya". При необходимости она может быть перемещена или удалена.
            this.tip_avtomobilyaTableAdapter.Fill(this.testDataSet.Tip_avtomobilya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Dolznost". При необходимости она может быть перемещена или удалена.
            this.dolznostTableAdapter.Fill(this.testDataSet.Dolznost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Pol". При необходимости она может быть перемещена или удалена.
            this.polTableAdapter.Fill(this.testDataSet.Pol);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Dolznost". При необходимости она может быть перемещена или удалена.
            this.dolznostTableAdapter.Fill(this.testDataSet.Dolznost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Pol". При необходимости она может быть перемещена или удалена.
            this.polTableAdapter.Fill(this.testDataSet.Pol);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Avtomobil". При необходимости она может быть перемещена или удалена.
            this.avtomobilTableAdapter.Fill(this.testDataSet.Avtomobil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.testDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Zakupka_avtomobiley". При необходимости она может быть перемещена или удалена.
            this.zakupka_avtomobileyTableAdapter.Fill(this.testDataSet.Zakupka_avtomobiley);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            zakupkaavtomobileyBindingSource.EndEdit();
            zakupka_avtomobileyTableAdapter.Update(testDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm3 af = new AddForm3();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 dlg = new Form1();
            dlg.Show(this);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SearchForm2 sf = new SearchForm2();
            sf.Owner = this;
            sf.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AddForm2 af = new AddForm2();
            af.Owner = this;
            af.Show();
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            sotrudnikBindingSource.EndEdit();
            sotrudnikTableAdapter.Update(testDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchForm3 sf = new SearchForm3();
            sf.Owner = this;
            sf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
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

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SaveButton3_Click(object sender, EventArgs e)
        {
            avtomobilBindingSource.EndEdit();
            avtomobilTableAdapter.Update(testDataSet);
        }
    }
}
