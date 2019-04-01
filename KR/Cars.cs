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
    public partial class Cars : Form
    {
        public RentCarController ctrl;
        public Form1 parent;
        private List<Car> cars;
        private BookForm bookForm;
        public Cars(RentCarController ctrl, Form1 parent)
        {
            this.ctrl = ctrl;
            this.parent = parent;
            InitializeComponent();
            label1.TextAlign = ContentAlignment.MiddleCenter;
            FillCars();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void FillCars()
        {
            cars = ctrl.GetCars();
            foreach (Car car in cars)
            {
                carBindingSource.Add(car);
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(parent.user == null)
            {
                parent.showForm();
            }
            else
            {
                bookForm = new BookForm(this, cars[e.RowIndex]);
                bookForm.Show();
            }
        }

        public void CloseForm()
        {
            bookForm.Hide();
        }

        public void AddBook(Book book)
        {
            ctrl.Add(book);
            CloseForm();
        }
    }
}
