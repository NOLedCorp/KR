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
                groupBox2.Visible = false;
                groupBox3.Visible = false; 
            }
            ShowBooks();

            
        }

        private void ShowBooks()
        {
            bookViewBindingSource.Clear();
            if (parent.user.IsAdmin)
            {
                books = parent.ctrl.GetBooks();
            }
            else
            {
                books = parent.ctrl.GetUserBooks(parent.user.UserId);
            }
            
            bookViewBindingSource.DataSource = books.Select(x => new BookView { BookId = x.BookId, Car = x.Car.Model, DateFinish = x.DateFinish, DateStart = x.DateStart });
           
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

        private void button2_Click(object sender, EventArgs e)
        {
            parent.user = null;
            parent.ctrl.Exit();
            parent.автомобилиToolStripMenuItem_Click();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var st = new Statistics();
            st.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = parent.ctrl.GetUsers();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {
                var u = (User)userBindingSource[e.RowIndex];
                parent.ctrl.Update(u);
            }
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if(name.Text != parent.user.Name)
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (email.Text != parent.user.Email)
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parent.user.Name = name.Text;
            parent.user.Email = email.Text;
            parent.ctrl.Update(parent.user);
            button4.Visible = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                chBookForm = new ChangeBook(books[e.RowIndex], this);
                chBookForm.Show();
            }
            
        }

        private void find_Click(object sender, EventArgs e)
        {
            userBindingSource.DataSource = parent.ctrl.GetUsers().FindAll(x => x.Email.StartsWith(textBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userBindingSource.DataSource = parent.ctrl.GetUsers();
        }
    }
}
