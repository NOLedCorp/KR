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
        private Form[] forms = new Form[4] { null, null, null, null};
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            Cars carsForm = new Cars();
            carsForm.MdiParent = this;
            carsForm.WindowState = FormWindowState.Maximized;

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
            carsForm.WindowState = FormWindowState.Maximized;
            forms[0] = carsForm;
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
            reportsForm.WindowState = FormWindowState.Maximized;
            forms[1] = reportsForm;
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
            profileForm.WindowState = FormWindowState.Maximized;
            forms[2] = profileForm;
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
            aboutForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            aboutForm.WindowState = FormWindowState.Maximized;
            forms[3] = aboutForm;
            curForm = aboutForm;
            curForm.Show();
        }
    }
}
