using System.Windows.Forms;

namespace KR
{
    partial class Reports
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportsBox = new System.Windows.Forms.GroupBox();
            this.p = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.reportsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            // reportsBox
            // 
            this.reportsBox.Controls.Add(this.p);
            this.reportsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.reportsBox.Location = new System.Drawing.Point(0, 0);
            this.reportsBox.Name = "reportsBox";
            this.reportsBox.Size = new System.Drawing.Size(800, 407);
            this.reportsBox.TabIndex = 1;
            this.reportsBox.TabStop = false;
            this.reportsBox.Text = "Отзывы";
            // 
            // p
            // 
            this.p.AutoScroll = true;
            this.p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p.Location = new System.Drawing.Point(3, 25);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(794, 379);
            this.p.TabIndex = 0;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportsBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.reportsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox reportsBox;
        private FlowLayoutPanel p;
    }
}