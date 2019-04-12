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
    public partial class ChangeBook : Form
    {
        public Book _book { get; set; }
        public Profile parent { get; set; }
        public ChangeBook(Book book, Profile profile)
        {
            _book = book;
            parent = profile;
            InitializeComponent();
            textBox4.Text = book.Car.Model;
            dateTimePicker1.Value = book.DateStart;
            dateTimePicker2.Value = book.DateFinish;
            if (book.DateStart < DateTime.Now || (book.DateStart - DateTime.Now).Days < 5)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;

            }
            if (parent.parent.user.IsAdmin)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            if (book.DateStart < DateTime.Now)
            {
                button2.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value < DateTime.Now || dateTimePicker2.Value < dateTimePicker1.Value)
            {
                note.Visible = true;
                return;
            }
            _book.DateStart = dateTimePicker1.Value;
            _book.DateFinish = dateTimePicker2.Value;
            parent.parent.ctrl.Update(_book);
            parent.CloseChangeForm();
        }

        private void clearNote(object sender, EventArgs e)
        {
            note.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.parent.ctrl.Remove(_book);
            parent.CloseChangeForm();
        }
    }
}
