namespace KR
{
    partial class ChangeCar
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
            this.button1 = new System.Windows.Forms.Button();
            this.doors = new System.Windows.Forms.NumericUpDown();
            this.fuel = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.consumption = new System.Windows.Forms.NumericUpDown();
            this.note = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumption)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doors
            // 
            this.doors.Location = new System.Drawing.Point(56, 190);
            this.doors.Name = "doors";
            this.doors.Size = new System.Drawing.Size(247, 20);
            this.doors.TabIndex = 25;
            this.doors.ValueChanged += new System.EventHandler(this.clearNote);
            // 
            // fuel
            // 
            this.fuel.FormattingEnabled = true;
            this.fuel.Items.AddRange(new object[] {
            "Бензин",
            "Дизель"});
            this.fuel.Location = new System.Drawing.Point(322, 137);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(180, 21);
            this.fuel.TabIndex = 24;
            this.fuel.SelectedIndexChanged += new System.EventHandler(this.clearNote);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(56, 252);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(446, 120);
            this.description.TabIndex = 23;
            this.description.TextChanged += new System.EventHandler(this.clearNote);
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(56, 84);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(247, 20);
            this.model.TabIndex = 21;
            this.model.TextChanged += new System.EventHandler(this.clearNote);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Описание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Топливо";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Расход топлива (л/100км)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Количество дверей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Изменение автомобиля";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(427, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // price
            // 
            this.price.DecimalPlaces = 2;
            this.price.Location = new System.Drawing.Point(56, 137);
            this.price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(247, 20);
            this.price.TabIndex = 30;
            this.price.ValueChanged += new System.EventHandler(this.clearNote);
            // 
            // consumption
            // 
            this.consumption.DecimalPlaces = 2;
            this.consumption.Location = new System.Drawing.Point(322, 84);
            this.consumption.Maximum = new decimal(new int[] {
            10900,
            0,
            0,
            0});
            this.consumption.Name = "consumption";
            this.consumption.Size = new System.Drawing.Size(180, 20);
            this.consumption.TabIndex = 29;
            this.consumption.ValueChanged += new System.EventHandler(this.clearNote);
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.note.Location = new System.Drawing.Point(211, 399);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(176, 13);
            this.note.TabIndex = 31;
            this.note.Text = "Поля не могут остаться пустыми";
            this.note.Visible = false;
            // 
            // ChangeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.note);
            this.Controls.Add(this.price);
            this.Controls.Add(this.consumption);
            this.Controls.Add(this.button2);
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
            this.Name = "ChangeCar";
            this.Text = "Изменение автомобиля";
            ((System.ComponentModel.ISupportInitialize)(this.doors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown doors;
        private System.Windows.Forms.ComboBox fuel;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.NumericUpDown consumption;
        private System.Windows.Forms.Label note;
    }
}