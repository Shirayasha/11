
namespace _11
{
    partial class AddForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.zakupkaavtomobileyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new _11.testDataSet();
            this.avtomobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGod = new System.Windows.Forms.TextBox();
            this.tbStoimost = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.sotrudnikTableAdapter = new _11.testDataSetTableAdapters.SotrudnikTableAdapter();
            this.zakupka_avtomobileyTableAdapter = new _11.testDataSetTableAdapters.Zakupka_avtomobileyTableAdapter();
            this.avtomobilTableAdapter = new _11.testDataSetTableAdapters.AvtomobilTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkaavtomobileyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbGod);
            this.groupBox1.Controls.Add(this.tbStoimost);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Автомобиль";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zakupkaavtomobileyBindingSource, "ID_Avtomobil", true));
            this.comboBox2.DataSource = this.avtomobilBindingSource;
            this.comboBox2.DisplayMember = "Marka";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 197);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 28);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "ID_Avtomobil";
            // 
            // zakupkaavtomobileyBindingSource
            // 
            this.zakupkaavtomobileyBindingSource.DataMember = "Zakupka_avtomobiley";
            this.zakupkaavtomobileyBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtomobilBindingSource
            // 
            this.avtomobilBindingSource.DataMember = "Avtomobil";
            this.avtomobilBindingSource.DataSource = this.testDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сотрудник";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zakupkaavtomobileyBindingSource, "ID_Sotrudnik", true));
            this.comboBox1.DataSource = this.sotrudnikBindingSource;
            this.comboBox1.DisplayMember = "Familiya";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "ID_Sotrudnik";
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.testDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Год выпуска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Стоимость";
            // 
            // tbGod
            // 
            this.tbGod.Location = new System.Drawing.Point(188, 91);
            this.tbGod.Name = "tbGod";
            this.tbGod.Size = new System.Drawing.Size(169, 26);
            this.tbGod.TabIndex = 1;
            // 
            // tbStoimost
            // 
            this.tbStoimost.Location = new System.Drawing.Point(188, 36);
            this.tbStoimost.Name = "tbStoimost";
            this.tbStoimost.Size = new System.Drawing.Size(169, 26);
            this.tbStoimost.TabIndex = 0;
            this.tbStoimost.TextChanged += new System.EventHandler(this.tbStoimost_TextChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.Location = new System.Drawing.Point(13, 291);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Location = new System.Drawing.Point(318, 291);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // zakupka_avtomobileyTableAdapter
            // 
            this.zakupka_avtomobileyTableAdapter.ClearBeforeFill = true;
            // 
            // avtomobilTableAdapter
            // 
            this.avtomobilTableAdapter.ClearBeforeFill = true;
            // 
            // AddForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(405, 326);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm3";
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkaavtomobileyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbStoimost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private testDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource zakupkaavtomobileyBindingSource;
        private testDataSetTableAdapters.Zakupka_avtomobileyTableAdapter zakupka_avtomobileyTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource avtomobilBindingSource;
        private testDataSetTableAdapters.AvtomobilTableAdapter avtomobilTableAdapter;
    }
}