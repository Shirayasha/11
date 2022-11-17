
namespace _11
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.remontavtomobileyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new _11.testDataSet();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.mekhanikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.avtomobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.remontBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbStoim = new System.Windows.Forms.TextBox();
            this.remontTableAdapter = new _11.testDataSetTableAdapters.RemontTableAdapter();
            this.remont_avtomobileyTableAdapter = new _11.testDataSetTableAdapters.Remont_avtomobileyTableAdapter();
            this.avtomobilTableAdapter = new _11.testDataSetTableAdapters.AvtomobilTableAdapter();
            this.mekhanikTableAdapter = new _11.testDataSetTableAdapters.MekhanikTableAdapter();
            this.klientTableAdapter = new _11.testDataSetTableAdapters.KlientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remontavtomobileyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mekhanikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remontBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.tbStoim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Клиент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Механик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Автомобиль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ремонт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стоимость";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата проведения";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.remontavtomobileyBindingSource, "ID_Klient", true));
            this.comboBox4.DataSource = this.klientBindingSource;
            this.comboBox4.DisplayMember = "Familiya";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(165, 339);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(193, 26);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.ValueMember = "ID_Klient";
            // 
            // remontavtomobileyBindingSource
            // 
            this.remontavtomobileyBindingSource.DataMember = "Remont_avtomobiley";
            this.remontavtomobileyBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.testDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.remontavtomobileyBindingSource, "ID_Mekhanik", true));
            this.comboBox3.DataSource = this.mekhanikBindingSource;
            this.comboBox3.DisplayMember = "Familiya";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(165, 280);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(193, 26);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "ID_Mekhanik";
            // 
            // mekhanikBindingSource
            // 
            this.mekhanikBindingSource.DataMember = "Mekhanik";
            this.mekhanikBindingSource.DataSource = this.testDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.remontavtomobileyBindingSource, "ID_Avtomobil", true));
            this.comboBox2.DataSource = this.avtomobilBindingSource;
            this.comboBox2.DisplayMember = "Marka";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(165, 224);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 26);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "ID_Avtomobil";
            // 
            // avtomobilBindingSource
            // 
            this.avtomobilBindingSource.DataMember = "Avtomobil";
            this.avtomobilBindingSource.DataSource = this.testDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.remontavtomobileyBindingSource, "ID_Remont", true));
            this.comboBox1.DataSource = this.remontBindingSource;
            this.comboBox1.DisplayMember = "Sostoyanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 26);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID_Remont";
            // 
            // remontBindingSource
            // 
            this.remontBindingSource.DataMember = "Remont";
            this.remontBindingSource.DataSource = this.testDataSet;
            // 
            // tbStoim
            // 
            this.tbStoim.Location = new System.Drawing.Point(165, 108);
            this.tbStoim.Name = "tbStoim";
            this.tbStoim.Size = new System.Drawing.Size(193, 24);
            this.tbStoim.TabIndex = 1;
            // 
            // remontTableAdapter
            // 
            this.remontTableAdapter.ClearBeforeFill = true;
            // 
            // remont_avtomobileyTableAdapter
            // 
            this.remont_avtomobileyTableAdapter.ClearBeforeFill = true;
            // 
            // avtomobilTableAdapter
            // 
            this.avtomobilTableAdapter.ClearBeforeFill = true;
            // 
            // mekhanikTableAdapter
            // 
            this.mekhanikTableAdapter.ClearBeforeFill = true;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(315, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(13, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(403, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remontavtomobileyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mekhanikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remontBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbStoim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource remontBindingSource;
        private testDataSetTableAdapters.RemontTableAdapter remontTableAdapter;
        private System.Windows.Forms.BindingSource remontavtomobileyBindingSource;
        private testDataSetTableAdapters.Remont_avtomobileyTableAdapter remont_avtomobileyTableAdapter;
        private System.Windows.Forms.BindingSource avtomobilBindingSource;
        private testDataSetTableAdapters.AvtomobilTableAdapter avtomobilTableAdapter;
        private System.Windows.Forms.BindingSource mekhanikBindingSource;
        private testDataSetTableAdapters.MekhanikTableAdapter mekhanikTableAdapter;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private testDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}