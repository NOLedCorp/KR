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
    public partial class Form1 : Form
    {
        private Form curForm;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            Cars carsForm = new Cars();
            carsForm.FormBorderStyle = FormBorderStyle.None;
            carsForm.MdiParent = this;
            carsForm.WindowState = FormWindowState.Maximized;
            carsForm.Dock = DockStyle.Fill;
            this.curForm = carsForm;
            curForm.Show();
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curForm is Cars)
            {
                return;
            }
            curForm.Close();
            Cars carsForm = new Cars();
            carsForm.MdiParent = this;
            carsForm.FormBorderStyle = FormBorderStyle.None;
            carsForm.Dock = DockStyle.Fill;
            this.curForm = carsForm;
            curForm.Show();

        }

        private void отзывыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(curForm is Reports)
            {
                return;
            }
            curForm.Close();
            Reports reportsForm = new Reports();
            reportsForm.MdiParent = this;
            reportsForm.Dock = DockStyle.Fill;
            reportsForm.FormBorderStyle = FormBorderStyle.None;
            curForm = reportsForm;
            curForm.Show();
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curForm is Profile)
            {
                return;
            }
            curForm.Close();
            Profile profileForm = new Profile();
            profileForm.MdiParent = this;
            profileForm.Dock = DockStyle.Fill;
            profileForm.FormBorderStyle = FormBorderStyle.None;
            curForm = profileForm;
            curForm.Show();
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
        }
    }
}
