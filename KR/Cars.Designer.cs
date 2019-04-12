namespace KR
{
    partial class Cars
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.consMore12 = new System.Windows.Forms.CheckBox();
            this.cons12 = new System.Windows.Forms.CheckBox();
            this.cons10 = new System.Windows.Forms.CheckBox();
            this.cons8 = new System.Windows.Forms.CheckBox();
            this.cons6 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deisel = new System.Windows.Forms.CheckBox();
            this.patrol = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Location = new System.Drawing.Point(481, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 108);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Сортировка";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton2.Location = new System.Drawing.Point(150, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Убывание";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton1.Location = new System.Drawing.Point(6, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Возрастание";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Модель",
            "Количество дверей",
            "Расход",
            "Цена"});
            this.comboBox1.Location = new System.Drawing.Point(6, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.changeSortType);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.consMore12);
            this.groupBox4.Controls.Add(this.cons12);
            this.groupBox4.Controls.Add(this.cons10);
            this.groupBox4.Controls.Add(this.cons8);
            this.groupBox4.Controls.Add(this.cons6);
            this.groupBox4.Location = new System.Drawing.Point(210, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 108);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Расход";
            // 
            // consMore12
            // 
            this.consMore12.AutoSize = true;
            this.consMore12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.consMore12.Location = new System.Drawing.Point(181, 29);
            this.consMore12.Name = "consMore12";
            this.consMore12.Size = new System.Drawing.Size(55, 24);
            this.consMore12.TabIndex = 4;
            this.consMore12.Text = ">12";
            this.consMore12.UseVisualStyleBackColor = true;
            this.consMore12.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // cons12
            // 
            this.cons12.AutoSize = true;
            this.cons12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cons12.Location = new System.Drawing.Point(120, 59);
            this.cons12.Name = "cons12";
            this.cons12.Size = new System.Drawing.Size(46, 24);
            this.cons12.TabIndex = 3;
            this.cons12.Text = "12";
            this.cons12.UseVisualStyleBackColor = true;
            this.cons12.CheckedChanged += new System.EventHandler(this.cons12_CheckedChanged);
            // 
            // cons10
            // 
            this.cons10.AutoSize = true;
            this.cons10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cons10.Location = new System.Drawing.Point(120, 29);
            this.cons10.Name = "cons10";
            this.cons10.Size = new System.Drawing.Size(46, 24);
            this.cons10.TabIndex = 2;
            this.cons10.Text = "10";
            this.cons10.UseVisualStyleBackColor = true;
            this.cons10.CheckedChanged += new System.EventHandler(this.cons10_CheckedChanged);
            // 
            // cons8
            // 
            this.cons8.AutoSize = true;
            this.cons8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cons8.Location = new System.Drawing.Point(61, 59);
            this.cons8.Name = "cons8";
            this.cons8.Size = new System.Drawing.Size(37, 24);
            this.cons8.TabIndex = 1;
            this.cons8.Text = "8";
            this.cons8.UseVisualStyleBackColor = true;
            this.cons8.CheckedChanged += new System.EventHandler(this.cons8_CheckedChanged);
            // 
            // cons6
            // 
            this.cons6.AutoSize = true;
            this.cons6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cons6.Location = new System.Drawing.Point(61, 29);
            this.cons6.Name = "cons6";
            this.cons6.Size = new System.Drawing.Size(37, 24);
            this.cons6.TabIndex = 0;
            this.cons6.Text = "6";
            this.cons6.UseVisualStyleBackColor = true;
            this.cons6.CheckedChanged += new System.EventHandler(this.cons6_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deisel);
            this.groupBox3.Controls.Add(this.patrol);
            this.groupBox3.Location = new System.Drawing.Point(29, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 108);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип топлива";
            // 
            // deisel
            // 
            this.deisel.AutoSize = true;
            this.deisel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deisel.Location = new System.Drawing.Point(44, 59);
            this.deisel.Name = "deisel";
            this.deisel.Size = new System.Drawing.Size(85, 24);
            this.deisel.TabIndex = 1;
            this.deisel.Text = "Дизель";
            this.deisel.UseVisualStyleBackColor = true;
            this.deisel.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // patrol
            // 
            this.patrol.AutoSize = true;
            this.patrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.patrol.Location = new System.Drawing.Point(44, 29);
            this.patrol.Name = "patrol";
            this.patrol.Size = new System.Drawing.Size(83, 24);
            this.patrol.TabIndex = 0;
            this.patrol.Text = "Бензин";
            this.patrol.UseVisualStyleBackColor = true;
            this.patrol.CheckedChanged += new System.EventHandler(this.patrol_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1082, 43);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(274, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Иван Номоконов (2018-2019). Все права защищены.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.doorsDataGridViewTextBoxColumn,
            this.consumptionDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.fuelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(KR.Models.Car);
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doorsDataGridViewTextBoxColumn
            // 
            this.doorsDataGridViewTextBoxColumn.DataPropertyName = "Doors";
            this.doorsDataGridViewTextBoxColumn.FillWeight = 150F;
            this.doorsDataGridViewTextBoxColumn.HeaderText = "Кол-во дверей";
            this.doorsDataGridViewTextBoxColumn.Name = "doorsDataGridViewTextBoxColumn";
            this.doorsDataGridViewTextBoxColumn.ReadOnly = true;
            this.doorsDataGridViewTextBoxColumn.Width = 150;
            // 
            // consumptionDataGridViewTextBoxColumn
            // 
            this.consumptionDataGridViewTextBoxColumn.DataPropertyName = "Consumption";
            this.consumptionDataGridViewTextBoxColumn.HeaderText = "Расход (л/100км)";
            this.consumptionDataGridViewTextBoxColumn.Name = "consumptionDataGridViewTextBoxColumn";
            this.consumptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.consumptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fuelDataGridViewTextBoxColumn
            // 
            this.fuelDataGridViewTextBoxColumn.DataPropertyName = "Fuel";
            this.fuelDataGridViewTextBoxColumn.HeaderText = "Топливо";
            this.fuelDataGridViewTextBoxColumn.Name = "fuelDataGridViewTextBoxColumn";
            this.fuelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cars";
            this.Text = "Cars";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox consMore12;
        private System.Windows.Forms.CheckBox cons12;
        private System.Windows.Forms.CheckBox cons10;
        private System.Windows.Forms.CheckBox cons8;
        private System.Windows.Forms.CheckBox cons6;
        private System.Windows.Forms.CheckBox deisel;
        private System.Windows.Forms.CheckBox patrol;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelDataGridViewTextBoxColumn;
    }
}