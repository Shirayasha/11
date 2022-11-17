
namespace _11
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrem = new System.Windows.Forms.TextBox();
            this.tbShtraf = new System.Windows.Forms.TextBox();
            this.tbItog = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.testDataSet = new _11.testDataSet();
            this.dolznostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolznostTableAdapter = new _11.testDataSetTableAdapters.DolznostTableAdapter();
            this.otdelbughalteriiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdel_bughalteriiTableAdapter = new _11.testDataSetTableAdapters.Otdel_bughalteriiTableAdapter();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new _11.testDataSetTableAdapters.SotrudnikTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolznostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelbughalteriiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.tbItog);
            this.groupBox1.Controls.Add(this.tbShtraf);
            this.groupBox1.Controls.Add(this.tbPrem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // tbPrem
            // 
            this.tbPrem.Location = new System.Drawing.Point(171, 39);
            this.tbPrem.Name = "tbPrem";
            this.tbPrem.Size = new System.Drawing.Size(158, 24);
            this.tbPrem.TabIndex = 0;
            // 
            // tbShtraf
            // 
            this.tbShtraf.Location = new System.Drawing.Point(171, 92);
            this.tbShtraf.Name = "tbShtraf";
            this.tbShtraf.Size = new System.Drawing.Size(158, 24);
            this.tbShtraf.TabIndex = 1;
            // 
            // tbItog
            // 
            this.tbItog.Location = new System.Drawing.Point(171, 149);
            this.tbItog.Name = "tbItog";
            this.tbItog.Size = new System.Drawing.Size(158, 24);
            this.tbItog.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.otdelbughalteriiBindingSource, "ID_Dolznost", true));
            this.comboBox1.DataSource = this.dolznostBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie_dolznosti";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 26);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ID_Dolznost";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.otdelbughalteriiBindingSource, "ID_Sotrudnik", true));
            this.comboBox2.DataSource = this.sotrudnikBindingSource;
            this.comboBox2.DisplayMember = "Familiya";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(171, 260);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 26);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "ID_Sotrudnik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Премия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Штраф";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Итоговая прибыль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Сотрудник";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(284, 349);
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
            this.button2.Location = new System.Drawing.Point(12, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // dolznostTableAdapter
            // 
            this.dolznostTableAdapter.ClearBeforeFill = true;
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
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.testDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(372, 384);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolznostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelbughalteriiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbItog;
        private System.Windows.Forms.TextBox tbShtraf;
        private System.Windows.Forms.TextBox tbPrem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource dolznostBindingSource;
        private testDataSetTableAdapters.DolznostTableAdapter dolznostTableAdapter;
        private System.Windows.Forms.BindingSource otdelbughalteriiBindingSource;
        private testDataSetTableAdapters.Otdel_bughalteriiTableAdapter otdel_bughalteriiTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private testDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
    }
}