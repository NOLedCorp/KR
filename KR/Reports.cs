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
    public partial class Reports : Form
    {
        private NewReport addForm;
        private List<Report> reports = new List<Report>()
        {
            new Report
            {
                ReportId = 1,
                User = new User
                {
                    UserId = 1,
                    Name = "Иван",
                    Email = "email@email.com",
                    Password = "123"
                },
                Text = "Отличный автомобиль",
                Mark = 5,
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
            }
        };
        public Reports()
        {
            InitializeComponent();
            foreach (Report r in reports)
            {

                this.ShowReport(r);
            }
            Button b = new Button();
            b.Text = "Добавить отзыв";
            b.Width = 200;
            b.Height = 40;
            b.Margin = new Padding(3, 14, 3, 3);
            b.Click += new System.EventHandler(ShowForm);
            p.Controls.Add(b);
        }

        private void ShowReport(Report r)
        {
            GroupBox rr = new GroupBox();
            rr.Height = 200;
            Panel pp = new Panel();
            pp.Dock = DockStyle.Fill;
            
            rr.Text = r.User.Name;


            Label date = new Label();
            date.Dock = DockStyle.Bottom;
            Label l = new Label();
            l.Dock = DockStyle.Fill;
            l.Font = new Font("Microsoft Sans Serif", 12);
            date.Font = new Font("Microsoft Sans Serif", 10);
            l.Text = r.Text;
            date.Text = "Дата: " + r.CreateDate.ToShortDateString();
            
            pp.Controls.Add(l);
            pp.AutoScroll = true;
            rr.Controls.Add(pp);
            rr.Controls.Add(date);
            p.Controls.Add(rr);
        }
        private void ShowForm(object sender, EventArgs e)
        {
            addForm = new NewReport();
            addForm.parent = this;
            addForm.Show();
        }

        public void CloseForm()
        {
            addForm.Hide();
        }

        public void AddReport(Report r)
        {
            reports.Add(r);
            p.Controls.Remove(p.Controls[p.Controls.Count - 1]);
            ShowReport(reports[reports.Count - 1]);
            Button b = new Button();
            b.Text = "Добавить отзыв";
            b.Width = 200;
            b.Height = 40;
            b.Margin = new Padding(3, 14, 3, 3);
            b.Click += new System.EventHandler(ShowForm);
            p.Controls.Add(b);
        }
    }
}
