
namespace _11
{
    partial class AddForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new _11.testDataSet();
            this.dolznostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.polBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPasp = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbIm = new System.Windows.Forms.TextBox();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbOklad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.polBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.polTableAdapter = new _11.testDataSetTableAdapters.PolTableAdapter();
            this.sotrudnikTableAdapter = new _11.testDataSetTableAdapters.SotrudnikTableAdapter();
            this.dolznostTableAdapter = new _11.testDataSetTableAdapters.DolznostTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolznostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPasp);
            this.groupBox1.Controls.Add(this.tbOtch);
            this.groupBox1.Controls.Add(this.tbIm);
            this.groupBox1.Controls.Add(this.tbFam);
            this.groupBox1.Controls.Add(this.tbOklad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Должность";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sotrudnikBindingSource, "ID_Dolznost", true));
            this.comboBox2.DataSource = this.dolznostBindingSource;
            this.comboBox2.DisplayMember = "Naimenovanie_dolznosti";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(233, 346);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 28);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "ID_Dolznost";
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dolznostBindingSource
            // 
            this.dolznostBindingSource.DataMember = "Dolznost";
            this.dolznostBindingSource.DataSource = this.testDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Пол";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sotrudnikBindingSource, "ID_Dolznost", true));
            this.comboBox1.DataSource = this.polBindingSource1;
            this.comboBox1.DisplayMember = "Naimenovanie_pola";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(233, 293);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "ID_Pol";
            // 
            // polBindingSource1
            // 
            this.polBindingSource1.DataMember = "Pol";
            this.polBindingSource1.DataSource = this.testDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Паспортные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // tbPasp
            // 
            this.tbPasp.Location = new System.Drawing.Point(233, 236);
            this.tbPasp.Name = "tbPasp";
            this.tbPasp.Size = new System.Drawing.Size(185, 26);
            this.tbPasp.TabIndex = 5;
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(233, 187);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(184, 26);
            this.tbOtch.TabIndex = 4;
            // 
            // tbIm
            // 
            this.tbIm.Location = new System.Drawing.Point(232, 136);
            this.tbIm.Name = "tbIm";
            this.tbIm.Size = new System.Drawing.Size(185, 26);
            this.tbIm.TabIndex = 3;
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(232, 83);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(185, 26);
            this.tbFam.TabIndex = 2;
            // 
            // tbOklad
            // 
            this.tbOklad.Location = new System.Drawing.Point(232, 35);
            this.tbOklad.Name = "tbOklad";
            this.tbOklad.Size = new System.Drawing.Size(185, 26);
            this.tbOklad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оклад";
            // 
            // polBindingSource
            // 
            this.polBindingSource.DataMember = "Pol";
            this.polBindingSource.DataSource = this.testDataSet;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Location = new System.Drawing.Point(382, 430);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.Location = new System.Drawing.Point(13, 431);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // polTableAdapter
            // 
            this.polTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // dolznostTableAdapter
            // 
            this.dolznostTableAdapter.ClearBeforeFill = true;
            // 
            // AddForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(471, 467);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm2";
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.AddForm2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolznostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPasp;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbIm;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbOklad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button AddBtn;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource polBindingSource;
        private testDataSetTableAdapters.PolTableAdapter polTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource polBindingSource1;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private testDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource dolznostBindingSource;
        private testDataSetTableAdapters.DolznostTableAdapter dolznostTableAdapter;
    }
}