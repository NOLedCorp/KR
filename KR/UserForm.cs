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
    public partial class UserForm : Form
    {
        public Form1 parent { get; set; }
        private RegForm regForm { get; set; }
        public UserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            regForm = new RegForm();
            regForm.parent = this;
            regForm.Show();
        }
        public void CloseForm()
        {
            regForm.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.EnterUser(textBox1.Text, textBox2.Text);
        }
    }
}
