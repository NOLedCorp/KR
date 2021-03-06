﻿using KR.Controllers;
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
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                note.Visible = true;
                return;
            }
            User user = new User
            {
                UserId = parent.parent.ctrl.GetNewUserId(),
                Name = textBox1.Text,
                Email = textBox2.Text,
                Password = textBox3.Text,
                IsAdmin = false
            };
            parent.parent.ctrl.Add(user);
            parent.CloseForm();

        }

        private void clearNote(object sender, EventArgs e)
        {
            note.Visible = false;

        }
    }
}
