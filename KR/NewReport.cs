using KR.Controllers;
using KR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    public partial class NewReport : Form
    {
        public Reports parent;
        private int Mark = -1;
        public NewReport(Reports parent)
        {
            InitializeComponent();
            this.parent = parent;
            textBox1.Text = parent.parent.user.Name;
            textBox2.Text = parent.parent.user.Email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || richTextBox1.Text == "" || Mark<0)
            {
                return;
            }
            parent.AddReport(new Report
            {
                ReportId = parent.parent.ctrl.GetNewReportId(),
                User = null,
                Text = richTextBox1.Text,
                Mark = Mark,
                Car = new Car
                {
                    CarId = 1,
                    Consumption = 8,
                    Description = "Норм авто",
                    Doors = 5,
                    Model = "VW Golf",
                    Fuel = "Бензин",
                    Price = 300
                },
                CreateDate = DateTime.Now
            });
            parent.CloseForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.CloseForm();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Mark = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Mark = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Mark = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Mark = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Mark = 5;
        }
    }
}
