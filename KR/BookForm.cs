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
            textBox4.Text = this.car.Model;
            textBox1.Text = this.parent.parent.user.Name;
            textBox2.Text = this.parent.parent.user.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                BookId = parent.ctrl.GetNewBookId(),
                User = parent.parent.user,
                Car = car,
                DateStart = dateTimePicker1.Value,
                DateFinish = dateTimePicker2.Value
            };
            parent.AddBook(book);
        }
    }
}
