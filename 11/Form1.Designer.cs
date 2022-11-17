
namespace _11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDZakupkaavtomobileyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godvypuskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Sotrudnik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sotrudnikBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new _11.testDataSet();
            this.ID_Avtomobil = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.avtomobilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zakupkaavtomobileyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avtomobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakupka_avtomobileyTableAdapter = new _11.testDataSetTableAdapters.Zakupka_avtomobileyTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.avtomobilTableAdapter = new _11.testDataSetTableAdapters.AvtomobilTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDAvtomobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godvypuskaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Tip_avtomobilya = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipavtomobilyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new _11.testDataSetTableAdapters.SotrudnikTableAdapter();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDSotrudnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportnyedannyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Pol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.polBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Dolznost = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dolznostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polTableAdapter = new _11.testDataSetTableAdapters.PolTableAdapter();
            this.dolznostTableAdapter = new _11.testDataSetTableAdapters.DolznostTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SaveButton3 = new System.Windows.Forms.Button();
            this.tip_avtomobilyaTableAdapter = new _11.testDataSetTableAdapters.Tip_avtomobilyaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkaavtomobileyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipavtomobilyaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolznostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZakupkaavtomobileyDataGridViewTextBoxColumn,
            this.stoimostDataGridViewTextBoxColumn,
            this.godvypuskaDataGridViewTextBoxColumn,
            this.ID_Sotrudnik,
            this.ID_Avtomobil});
            this.dataGridView1.DataSource = this.zakupkaavtomobileyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 137);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDZakupkaavtomobileyDataGridViewTextBoxColumn
            // 
            this.iDZakupkaavtomobileyDataGridViewTextBoxColumn.DataPropertyName = "ID_Zakupka_avtomobiley";
            this.iDZakupkaavtomobileyDataGridViewTextBoxColumn.HeaderText = "ИД Закупка автомобилей";
            this.iDZakupkaavtomobileyDataGridViewTextBoxColumn.Name = "iDZakupkaavtomobileyDataGridViewTextBoxColumn";
            this.iDZakupkaavtomobileyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // stoimostDataGridViewTextBoxColumn
            // 
            this.stoimostDataGridViewTextBoxColumn.DataPropertyName = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.stoimostDataGridViewTextBoxColumn.Name = "stoimostDataGridViewTextBoxColumn";
            // 
            // godvypuskaDataGridViewTextBoxColumn
            // 
            this.godvypuskaDataGridViewTextBoxColumn.DataPropertyName = "God_vypuska";
            this.godvypuskaDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.godvypuskaDataGridViewTextBoxColumn.Name = "godvypuskaDataGridViewTextBoxColumn";
            // 
            // ID_Sotrudnik
            // 
            this.ID_Sotrudnik.DataPropertyName = "ID_Sotrudnik";
            this.ID_Sotrudnik.DataSource = this.sotrudnikBindingSource3;
            this.ID_Sotrudnik.DisplayMember = "Familiya";
            this.ID_Sotrudnik.HeaderText = "Сотрудник";
            this.ID_Sotrudnik.Name = "ID_Sotrudnik";
            this.ID_Sotrudnik.ValueMember = "ID_Sotrudnik";
            // 
            // sotrudnikBindingSource3
            // 
            this.sotrudnikBindingSource3.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource3.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_Avtomobil
            // 
            this.ID_Avtomobil.DataPropertyName = "ID_Avtomobil";
            this.ID_Avtomobil.DataSource = this.avtomobilBindingSource1;
            this.ID_Avtomobil.DisplayMember = "Marka";
            this.ID_Avtomobil.HeaderText = "Автомобиль";
            this.ID_Avtomobil.Name = "ID_Avtomobil";
            this.ID_Avtomobil.ValueMember = "ID_Avtomobil";
            // 
            // avtomobilBindingSource1
            // 
            this.avtomobilBindingSource1.DataMember = "Avtomobil";
            this.avtomobilBindingSource1.DataSource = this.testDataSet;
            // 
            // zakupkaavtomobileyBindingSource
            // 
            this.zakupkaavtomobileyBindingSource.DataMember = "Zakupka_avtomobiley";
            this.zakupkaavtomobileyBindingSource.DataSource = this.testDataSet;
            // 
            // sotrudnikBindingSource1
            // 
            this.sotrudnikBindingSource1.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource1.DataSource = this.testDataSet;
            // 
            // avtomobilBindingSource
            // 
            this.avtomobilBindingSource.DataMember = "Avtomobil";
            this.avtomobilBindingSource.DataSource = this.testDataSet;
            // 
            // zakupka_avtomobileyTableAdapter
            // 
            this.zakupka_avtomobileyTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(896, 117);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(896, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(896, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(936, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // avtomobilTableAdapter
            // 
            this.avtomobilTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAvtomobilDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.godvypuskaDataGridViewTextBoxColumn1,
            this.stoimostDataGridViewTextBoxColumn1,
            this.ID_Tip_avtomobilya});
            this.dataGridView3.DataSource = this.avtomobilBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(14, 353);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(876, 150);
            this.dataGridView3.TabIndex = 8;
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // iDAvtomobilDataGridViewTextBoxColumn
            // 
            this.iDAvtomobilDataGridViewTextBoxColumn.DataPropertyName = "ID_Avtomobil";
            this.iDAvtomobilDataGridViewTextBoxColumn.HeaderText = "ИД Автомобиль";
            this.iDAvtomobilDataGridViewTextBoxColumn.Name = "iDAvtomobilDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // godvypuskaDataGridViewTextBoxColumn1
            // 
            this.godvypuskaDataGridViewTextBoxColumn1.DataPropertyName = "God_vypuska";
            this.godvypuskaDataGridViewTextBoxColumn1.HeaderText = "Год выпуска";
            this.godvypuskaDataGridViewTextBoxColumn1.Name = "godvypuskaDataGridViewTextBoxColumn1";
            // 
            // stoimostDataGridViewTextBoxColumn1
            // 
            this.stoimostDataGridViewTextBoxColumn1.DataPropertyName = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn1.HeaderText = "Стоимость";
            this.stoimostDataGridViewTextBoxColumn1.Name = "stoimostDataGridViewTextBoxColumn1";
            // 
            // ID_Tip_avtomobilya
            // 
            this.ID_Tip_avtomobilya.DataPropertyName = "ID_Tip_avtomobilya";
            this.ID_Tip_avtomobilya.DataSource = this.tipavtomobilyaBindingSource;
            this.ID_Tip_avtomobilya.DisplayMember = "Naimenovanie_tipa_avtomobilya";
            this.ID_Tip_avtomobilya.HeaderText = "Тип автомобиля";
            this.ID_Tip_avtomobilya.Name = "ID_Tip_avtomobilya";
            this.ID_Tip_avtomobilya.ValueMember = "ID_Tip_avtomobilya";
            // 
            // tipavtomobilyaBindingSource
            // 
            this.tipavtomobilyaBindingSource.DataMember = "Tip_avtomobilya";
            this.tipavtomobilyaBindingSource.DataSource = this.testDataSet;
            // 
            // sotrudnikBindingSource2
            // 
            this.sotrudnikBindingSource2.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource2.DataSource = this.testDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.testDataSet;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(896, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSotrudnikDataGridViewTextBoxColumn,
            this.okladDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.otchestvoDataGridViewTextBoxColumn,
            this.pasportnyedannyeDataGridViewTextBoxColumn,
            this.ID_Pol,
            this.ID_Dolznost});
            this.dataGridView2.DataSource = this.sotrudnikBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(14, 177);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(876, 150);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // iDSotrudnikDataGridViewTextBoxColumn
            // 
            this.iDSotrudnikDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrudnik";
            this.iDSotrudnikDataGridViewTextBoxColumn.HeaderText = "ИД Сотрудник";
            this.iDSotrudnikDataGridViewTextBoxColumn.Name = "iDSotrudnikDataGridViewTextBoxColumn";
            // 
            // okladDataGridViewTextBoxColumn
            // 
            this.okladDataGridViewTextBoxColumn.DataPropertyName = "Oklad";
            this.okladDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.okladDataGridViewTextBoxColumn.Name = "okladDataGridViewTextBoxColumn";
            // 
            // familiyaDataGridViewTextBoxColumn
            // 
            this.familiyaDataGridViewTextBoxColumn.DataPropertyName = "Familiya";
            this.familiyaDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.familiyaDataGridViewTextBoxColumn.Name = "familiyaDataGridViewTextBoxColumn";
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "Imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            // 
            // otchestvoDataGridViewTextBoxColumn
            // 
            this.otchestvoDataGridViewTextBoxColumn.DataPropertyName = "Otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.otchestvoDataGridViewTextBoxColumn.Name = "otchestvoDataGridViewTextBoxColumn";
            // 
            // pasportnyedannyeDataGridViewTextBoxColumn
            // 
            this.pasportnyedannyeDataGridViewTextBoxColumn.DataPropertyName = "Pasportnye_dannye";
            this.pasportnyedannyeDataGridViewTextBoxColumn.HeaderText = "Паспортные данные";
            this.pasportnyedannyeDataGridViewTextBoxColumn.Name = "pasportnyedannyeDataGridViewTextBoxColumn";
            // 
            // ID_Pol
            // 
            this.ID_Pol.DataPropertyName = "ID_Pol";
            this.ID_Pol.DataSource = this.polBindingSource;
            this.ID_Pol.DisplayMember = "Naimenovanie_pola";
            this.ID_Pol.HeaderText = "Пол";
            this.ID_Pol.Name = "ID_Pol";
            this.ID_Pol.ValueMember = "ID_Pol";
            // 
            // polBindingSource
            // 
            this.polBindingSource.DataMember = "Pol";
            this.polBindingSource.DataSource = this.testDataSet;
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
            // polTableAdapter
            // 
            this.polTableAdapter.ClearBeforeFill = true;
            // 
            // dolznostTableAdapter
            // 
            this.dolznostTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(896, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // SaveButton2
            // 
            this.SaveButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton2.Location = new System.Drawing.Point(896, 295);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(75, 23);
            this.SaveButton2.TabIndex = 11;
            this.SaveButton2.Text = "Сохранить";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton2_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(896, 365);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(896, 416);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // SaveButton3
            // 
            this.SaveButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton3.Location = new System.Drawing.Point(896, 470);
            this.SaveButton3.Name = "SaveButton3";
            this.SaveButton3.Size = new System.Drawing.Size(75, 23);
            this.SaveButton3.TabIndex = 14;
            this.SaveButton3.Text = "Сохранить";
            this.SaveButton3.UseVisualStyleBackColor = true;
            this.SaveButton3.Click += new System.EventHandler(this.SaveButton3_Click);
            // 
            // tip_avtomobilyaTableAdapter
            // 
            this.tip_avtomobilyaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1023, 560);
            this.Controls.Add(this.SaveButton3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.SaveButton2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Закупка автомобилей";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkaavtomobileyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtomobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipavtomobilyaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolznostBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public testDataSet testDataSet;
        public System.Windows.Forms.BindingSource zakupkaavtomobileyBindingSource;
        public testDataSetTableAdapters.Zakupka_avtomobileyTableAdapter zakupka_avtomobileyTableAdapter;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.BindingSource avtomobilBindingSource;
        public testDataSetTableAdapters.AvtomobilTableAdapter avtomobilTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource avtomobilBindingSource1;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource1;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource2;
        public testDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        public System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource polBindingSource;
        private testDataSetTableAdapters.PolTableAdapter polTableAdapter;
        private System.Windows.Forms.BindingSource dolznostBindingSource;
        private testDataSetTableAdapters.DolznostTableAdapter dolznostTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportnyedannyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Pol;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Dolznost;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button SaveButton2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZakupkaavtomobileyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godvypuskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sotrudnik;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource3;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Avtomobil;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button SaveButton3;
        private System.Windows.Forms.BindingSource tipavtomobilyaBindingSource;
        private testDataSetTableAdapters.Tip_avtomobilyaTableAdapter tip_avtomobilyaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAvtomobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godvypuskaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Tip_avtomobilya;
    }
}

