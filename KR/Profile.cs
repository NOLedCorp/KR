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
    public partial class Profile : Form
    {
        public Form1 parent { get; set; }
        private CarForm addCarForm;
        public Profile(Form1 p)
        {
            InitializeComponent();
            parent = p;
            name.Text = parent.user.Name;
            email.Text = parent.user.Email;
            if (!parent.user.IsAdmin)
            {
                button1.Visible = false;
                button1.Enabled = false;
            }
            foreach(BookView b in parent.ctrl.GetUserBooks(parent.user.UserId).Select(x => new BookView { BookId = x.BookId, Car = x.Car.Model, DateFinish = x.DateFinish, DateStart = x.DateStart}))
            {
                bookViewBindingSource.Add(b);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCarForm = new CarForm();
            addCarForm.parent = this;
            addCarForm.ctrl = parent.ctrl;
            addCarForm.Show();
        }
        public void CloseForm()
        {
            addCarForm.Hide();
        }

        public void AddCar(Car car)
        {
            parent.ctrl.Add(car);
            CloseForm();
        }
    }
}
