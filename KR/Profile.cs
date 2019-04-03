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
        private ChangeBook chBookForm;
        private List<Book> books;
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
            ShowBooks();
            
        }

        private void ShowBooks()
        {
            bookViewBindingSource.Clear();
            books = parent.ctrl.GetUserBooks(parent.user.UserId);
            foreach (BookView b in books.Select(x => new BookView { BookId = x.BookId, Car = x.Car.Model, DateFinish = x.DateFinish, DateStart = x.DateStart }))
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

        public void CloseChangeForm()
        {
            ShowBooks();
            chBookForm.Hide();
        }

        public void AddCar(Car car)
        {
            parent.ctrl.Add(car);
            CloseForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            chBookForm = new ChangeBook(books[e.RowIndex], this);
            chBookForm.Show();
        }
    }
}
