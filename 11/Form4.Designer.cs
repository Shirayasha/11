
namespace _11
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDOtdelbughalteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shtrafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itogovayapribilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Dolznost = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dolznostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new _11.testDataSet();
            this.ID_Sotrudnik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdelbughalteriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdel_bughalteriiTableAdapter = new _11.testDataSetTableAdapters.Otdel_bughalteriiTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDolznostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovaniedolznostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolznostTableAdapter = new _11.testDataSetTableAdapters.DolznostTableAdapter();
            this.sotrudnikTableAdapter = new _11.testDataSetTableAdapters.SotrudnikTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolznostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelbughalteriiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOtdelbughalteriiDataGridViewTextBoxColumn,
            this.premiyaDataGridViewTextBoxColumn,
            this.shtrafDataGridViewTextBoxColumn,
            this.itogovayapribilDataGridViewTextBoxColumn,
            this.ID_Dolznost,
            this.ID_Sotrudnik});
            this.dataGridView1.DataSource = this.otdelbughalteriiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDOtdelbughalteriiDataGridViewTextBoxColumn
            // 
            this.iDOtdelbughalteriiDataGridViewTextBoxColumn.DataPropertyName = "ID_Otdel_bughalterii";
            this.iDOtdelbughalteriiDataGridViewTextBoxColumn.HeaderText = "ИД Отдел бухгалтерии";
            this.iDOtdelbughalteriiDataGridViewTextBoxColumn.Name = "iDOtdelbughalteriiDataGridViewTextBoxColumn";
            // 
            // premiyaDataGridViewTextBoxColumn
            // 
            this.premiyaDataGridViewTextBoxColumn.DataPropertyName = "Premiya";
            this.premiyaDataGridViewTextBoxColumn.HeaderText = "Премия";
            this.premiyaDataGridViewTextBoxColumn.Name = "premiyaDataGridViewTextBoxColumn";
            // 
            // shtrafDataGridViewTextBoxColumn
            // 
            this.shtrafDataGridViewTextBoxColumn.DataPropertyName = "Shtraf";
            this.shtrafDataGridViewTextBoxColumn.HeaderText = "Штраф";
            this.shtrafDataGridViewTextBoxColumn.Name = "shtrafDataGridViewTextBoxColumn";
            // 
            // itogovayapribilDataGridViewTextBoxColumn
            // 
            this.itogovayapribilDataGridViewTextBoxColumn.DataPropertyName = "Itogovaya_pribil";
            this.itogovayapribilDataGridViewTextBoxColumn.HeaderText = "Итоговая прибыль";
            this.itogovayapribilDataGridViewTextBoxColumn.Name = "itogovayapribilDataGridViewTextBoxColumn";
            // 
            // ID_Dolznost
            // 
            this.ID_Dolznost.DataPropertyName = "ID_Dolznost";
            this.ID_Dolznost.DataSource = this.dolznostBindingSource;
            this.ID_Dolznost.DisplayMember = "Naimenovanie_dolznosti";
            this.ID_Dolznost.HeaderText = "Должность";
            this.ID_Dolznost.Name = "ID_Dolznost";
            this.ID_Dolznost.ValueMember = "ID_Dolznost";
            // 
            // dolznostBindingSource
            // 
            this.dolznostBindingSource.DataMember = "Dolznost";
            this.dolznostBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_Sotrudnik
            // 
            this.ID_Sotrudnik.DataPropertyName = "ID_Sotrudnik";
            this.ID_Sotrudnik.DataSource = this.sotrudnikBindingSource;
            this.ID_Sotrudnik.DisplayMember = "Familiya";
            this.ID_Sotrudnik.HeaderText = "Сотрудник";
            this.ID_Sotrudnik.Name = "ID_Sotrudnik";
            this.ID_Sotrudnik.ValueMember = "ID_Sotrudnik";
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.testDataSet;
            // 
            // otdelbughalteriiBindingSource
            // 
            this.otdelbughalteriiBindingSource.DataMember = "Otdel_bughalterii";
            this.otdelbughalteriiBindingSource.DataSource = this.testDataSet;
            // 
            // otdel_bughalteriiTableAdapter
            // 
            this.otdel_bughalteriiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDolznostDataGridViewTextBoxColumn1,
            this.naimenovaniedolznostiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dolznostBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 209);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(667, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // iDDolznostDataGridViewTextBoxColumn1
            // 
            this.iDDolznostDataGridViewTextBoxColumn1.DataPropertyName = "ID_Dolznost";
            this.iDDolznostDataGridViewTextBoxColumn1.HeaderText = "ИД Должность";
            this.iDDolznostDataGridViewTextBoxColumn1.Name = "iDDolznostDataGridViewTextBoxColumn1";
            this.iDDolznostDataGridViewTextBoxColumn1.Width = 150;
            // 
            // naimenovaniedolznostiDataGridViewTextBoxColumn
            // 
            this.naimenovaniedolznostiDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie_dolznosti";
            this.naimenovaniedolznostiDataGridViewTextBoxColumn.HeaderText = "Наименование должности";
            this.naimenovaniedolznostiDataGridViewTextBoxColumn.Name = "naimenovaniedolznostiDataGridViewTextBoxColumn";
            this.naimenovaniedolznostiDataGridViewTextBoxColumn.Width = 150;
            // 
            // dolznostTableAdapter
            // 
            this.dolznostTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(687, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(686, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(687, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(687, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(687, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(687, 323);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(713, 396);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Закрыть";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolznostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelbughalteriiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public testDataSet testDataSet;
        public System.Windows.Forms.BindingSource otdelbughalteriiBindingSource;
        public testDataSetTableAdapters.Otdel_bughalteriiTableAdapter otdel_bughalteriiTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource dolznostBindingSource;
        public testDataSetTableAdapters.DolznostTableAdapter dolznostTableAdapter;
        public System.Windows.Forms.BindingSource sotrudnikBindingSource;
        public testDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOtdelbughalteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shtrafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itogovayapribilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Dolznost;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sotrudnik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDolznostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovaniedolznostiDataGridViewTextBoxColumn;
    }
}