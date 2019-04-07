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
    public partial class BookForm : Form
    {
        private Cars parent;
        private Car car;
        public BookForm(Cars parent, Car car)
        {
            this.parent = parent;
            this.car = car;
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(DateTime.Today.Ticks + TimeSpan.TicksPerDay);
            dateTimePicker2.Value = new DateTime(DateTime.Today.Ticks + TimeSpan.TicksPerDay*2);
            textBox4.Text = this.car.Model;
            textBox1.Text = this.parent.parent.user.Name;
            textBox2.Text = this.parent.parent.user.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now || dateTimePicker2.Value <= dateTimePicker1.Value)
            {
                note.Visible = true;
                return;
            }
            Book book = new Book
            {
                BookId = parent.ctrl.GetNewBookId(),
                User = parent.parent.user,
                Car = car,
                DateStart = dateTimePicker1.Value.Date,
                DateFinish = dateTimePicker2.Value.Date
            };
            parent.AddBook(book);
        }
        private void clearNote(object sender = null, EventArgs e = null)
        {
            note.Visible = false;

        }
    }
}
