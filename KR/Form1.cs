using KR.Controllers;
using KR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    
    public partial class Form1 : Form
    {
        public UserForm enterForm;
        private Form curForm;
        public User user = null;
        public RentCarController ctrl = new RentCarController();
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            Cars carsForm = new Cars(ctrl, this);
            carsForm.FormBorderStyle = FormBorderStyle.None;
            carsForm.MdiParent = this;
            carsForm.WindowState = FormWindowState.Maximized;
            carsForm.Dock = DockStyle.Fill;
            this.curForm = carsForm;
            curForm.Show();
            user = ctrl.GetU();
            автомобилиToolStripMenuItem.BackColor =  Color.LightGray;
        }

        public void автомобилиToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            if (curForm is Cars)
            {
                return;
            }
            curForm.Close();
            Cars carsForm = new Cars(ctrl, this);
            carsForm.MdiParent = this;
            carsForm.FormBorderStyle = FormBorderStyle.None;
            carsForm.Dock = DockStyle.Fill;
            this.curForm = carsForm;
            curForm.Show();
            Clear();
            автомобилиToolStripMenuItem.BackColor =  Color.LightGray;

        }

        private void отзывыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(curForm is Reports)
            {
                return;
            }
            curForm.Close();
            Reports reportsForm = new Reports(this);
            reportsForm.MdiParent = this;
            reportsForm.Dock = DockStyle.Fill;
            reportsForm.FormBorderStyle = FormBorderStyle.None;
            curForm = reportsForm;
            curForm.Show();
            Clear();
            отзывыToolStripMenuItem.BackColor =  Color.LightGray;
        }

        private void Clear()
        {
            личныйКабинетToolStripMenuItem.BackColor = SystemColors.Control;
            автомобилиToolStripMenuItem.BackColor = SystemColors.Control;
            отзывыToolStripMenuItem.BackColor = SystemColors.Control;
            оСебеToolStripMenuItem.BackColor = SystemColors.Control;
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curForm is Profile)
            {
                return;
            }
            
            if(user == null)
            {
                showForm();
            }
            else
            {
                curForm.Close();
                Profile profileForm = new Profile(this);
                profileForm.MdiParent = this;
                profileForm.Dock = DockStyle.Fill;
                profileForm.FormBorderStyle = FormBorderStyle.None;
                curForm = profileForm;
                curForm.Show();
                Clear();
                личныйКабинетToolStripMenuItem.BackColor =  Color.LightGray;
            }

        }

        public void showForm()
        {
            enterForm = new UserForm();
            enterForm.parent = this;
            enterForm.Show();
        }

        public void CloseForm()
        {
            enterForm.Hide();
        }

        private void оСебеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curForm is About)
            {
                return;
            }
            curForm.Close();
            About aboutForm = new About();
            aboutForm.MdiParent = this;
            aboutForm.MdiParent = this;
            aboutForm.Dock = DockStyle.Fill;
            aboutForm.FormBorderStyle = FormBorderStyle.None;
            curForm = aboutForm;
            curForm.Show();
            Clear();
            оСебеToolStripMenuItem.BackColor = Color.LightGray;
        }

        public void EnterUser(string email, string password, bool save)
        {
            user = ctrl.GetUser(email, password, save);
            CloseForm();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("notepad.exe", "readme.txt");
        }
    }
}
