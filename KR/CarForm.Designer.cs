namespace KR
{
    partial class CarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.fuel = new System.Windows.Forms.ComboBox();
            this.doors = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.note = new System.Windows.Forms.Label();
            this.consumption = new System.Windows.Forms.NumericUpDown();
            this.price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.doors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление автомобиля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество дверей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Расход топлива (л/100км)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Топливо";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Описание";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(35, 65);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(247, 20);
            this.model.TabIndex = 7;
            this.model.TextChanged += new System.EventHandler(this.clearNote);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(35, 233);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(446, 120);
            this.description.TabIndex = 9;
            this.description.TextChanged += new System.EventHandler(this.clearNote);
            // 
            // fuel
            // 
            this.fuel.FormattingEnabled = true;
            this.fuel.Items.AddRange(new object[] {
            "Бензин",
            "Дизель"});
            this.fuel.Location = new System.Drawing.Point(301, 118);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(180, 21);
            this.fuel.TabIndex = 10;
            this.fuel.SelectedIndexChanged += new System.EventHandler(this.clearNote);
            // 
            // doors
            // 
            this.doors.Location = new System.Drawing.Point(35, 171);
            this.doors.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.doors.Name = "doors";
            this.doors.Size = new System.Drawing.Size(247, 20);
            this.doors.TabIndex = 11;
            this.doors.ValueChanged += new System.EventHandler(this.clearNote);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.note.Location = new System.Drawing.Point(180, 380);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(111, 13);
            this.note.TabIndex = 14;
            this.note.Text = "Введите все данные";
            this.note.Visible = false;
            // 
            // consumption
            // 
            this.consumption.DecimalPlaces = 2;
            this.consumption.Location = new System.Drawing.Point(301, 66);
            this.consumption.Name = "consumption";
            this.consumption.Size = new System.Drawing.Size(180, 20);
            this.consumption.TabIndex = 15;
            this.consumption.ValueChanged += new System.EventHandler(this.clearNote);
            // 
            // price
            // 
            this.price.DecimalPlaces = 2;
            this.price.Location = new System.Drawing.Point(35, 118);
            this.price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(247, 20);
            this.price.TabIndex = 16;
            this.price.ValueChanged += new System.EventHandler(this.clearNote);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 418);
            this.Controls.Add(this.price);
            this.Controls.Add(this.consumption);
            this.Controls.Add(this.note);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doors);
            this.Controls.Add(this.fuel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarForm";
            this.Text = "Добавление автомобиля";
            ((System.ComponentModel.ISupportInitialize)(this.doors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox fuel;
        private System.Windows.Forms.NumericUpDown doors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.NumericUpDown consumption;
        private System.Windows.Forms.NumericUpDown price;
    }
}