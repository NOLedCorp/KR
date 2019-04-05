using KR.Controllers;
using KR.Models;
using KR.Services;
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
        public Form1 parent;
        private List<Report> reports;
        public Reports(Form1 p)
        {
            InitializeComponent();
            parent = p;
            foreach (Report r in parent.ctrl.GetReports())
            {

                this.ShowReport(r);
            }
            Button b = new Button();
            b.Text = "Добавить отзыв";
            b.Width = 200;
            b.Height = 40;
            b.Margin = new Padding(3, 14, 3, 3);
            b.Click += new System.EventHandler(ShowForm);
            this.p.Controls.Add(b);
        }

        private void ShowReport(Report r)
        {
            GroupBox rr = new GroupBox();
            rr.Height = 200;
            Panel pp = new Panel();
            pp.Dock = DockStyle.Fill;
            
            rr.Text = r.User.Name;

            Label car = new Label();
            car.Dock = DockStyle.Bottom;
            Label date = new Label();
            date.Dock = DockStyle.Bottom;
            
            Label l = new Label();
            l.Dock = DockStyle.Fill;
            l.Font = new Font("Microsoft Sans Serif", 12);
            date.Font = new Font("Microsoft Sans Serif", 10);
            car.Font = new Font("Microsoft Sans Serif", 10);
            l.Text = r.Text;
            date.Text = "Дата: " + r.CreateDate.ToShortDateString();
            car.Text = "Автомобиль: " + r.Car.Model;
            pp.Controls.Add(l);
            pp.AutoScroll = true;
            rr.Controls.Add(pp);
            rr.Controls.Add(date);
            rr.Controls.Add(car);
            p.Controls.Add(rr);
        }
        private void ShowForm(object sender, EventArgs e)
        {
            if(parent.user == null)
            {
                parent.showForm();
            }
            else
            {
                addForm = new NewReport(this);
                addForm.parent = this;
                addForm.Show();
            }
            
        }

        public void CloseForm()
        {
            addForm.Hide();
        }

        public void AddReport(Report r)
        {
            r.User = parent.user;
            parent.ctrl.Add(r);
            reports = parent.ctrl.GetReports();
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
