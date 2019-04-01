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
    public partial class RegForm : Form
    {
        public UserForm parent { get; set; }
        private RentCarController ctrl = new RentCarController();
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserId = ctrl.GetNewUserId(),
                Name = textBox1.Text,
                Email = textBox2.Text,
                Password = textBox3.Text,
                IsAdmin = false
            };
            ctrl.Add(user);
            parent.CloseForm();
        }
    }
}
