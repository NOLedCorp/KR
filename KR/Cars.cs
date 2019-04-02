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
        private List<Filter> filters = new List<Filter>();
        public Cars(RentCarController ctrl, Form1 parent)
        {
            this.ctrl = ctrl;
            this.parent = parent;
            InitializeComponent();
            label1.TextAlign = ContentAlignment.MiddleCenter;
            FillCars(cars = ctrl.GetCars());
            
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
            var f = filters.Find(f1 => f1.Name == "Fuel" && f1.Value == "Дизель");
            if (null == f)
            {
                filters.Add(new Filter { Name = "Fuel", Value = "Дизель" });
            }
            else
            {
                filters.Remove(f);
            }
            Filter();
        }
        private void FillCars(List<Car> cars)
        {
            carBindingSource.Clear();
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

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            var f = filters.Find(f1 => f1.Name == "Consumption" && f1.Value == "100");
            if (null == f)
            {
                filters.Add(new Filter { Name = "Consumption", Value = "100" });
            }
            else
            {
                filters.Remove(f);
            }
            Filter();
        }

        private void patrol_CheckedChanged(object sender, EventArgs e)
        {
            var f = filters.Find(f1 => f1.Name == "Fuel" && f1.Value == "Бензин");
            if (null == f)
            {
                filters.Add(new Filter { Name = "Fuel", Value = "Бензин" });
            }
            else
            {
                filters.Remove(f);
            }
            Filter();
        }

        private void cons6_CheckedChanged(object sender, EventArgs e)
        {
            var f = filters.Find(f1 => f1.Name == "Consumption" && f1.Value == "6");
            if (null == f)
            {
                filters.Add(new Filter { Name = "Consumption", Value = "6" });
            }
            else
            {
                filters.Remove(f);
            }
            Filter();
        }

        private void cons8_CheckedChanged(object sender, EventArgs e)
        {
            var f = filters.Find(f1 => f1.Name == "Consumption" && f1.Value == "8");
            if (null == f)
            {
                filters.Add(new Filter { Name = "Consumption", Value = "8" });
            }
            else
            {
                filters.Remove(f);
            }
            Filter();
        }

        private void cons10_CheckedChanged(object sender, EventArgs e)
        {
            var f = filters.Find(f1 => f1.Name == "Consumption" && f1.Value == "10");
            if (null == f)
            {
                filters.Add(new Filter { Name = "Consumption", Value = "10" });
            }
            else
            {
                filters.Remove(f);
            }
            Filter();
        }

        private void cons12_CheckedChanged(object sender, EventArgs e)
        {
            var f = filters.Find(f1 => f1.Name == "Consumption" && f1.Value == "12");
            if (null == f)
            {
                filters.Add(new Filter { Name = "Consumption", Value = "12" });
            }
            else
            {
                filters.Remove(f);
            }
            
            Filter();
        }

        private void Filter()
        {
            if (filters.Count == 0)
            {
                FillCars(cars);
            }
            else
            {
                List<Car> result = new List<Car>();
                foreach (Car c in cars)
                {
                    foreach (Filter f in filters)
                    {
                        if (c.Fuel == f.Value)
                        {
                            result.Add(c);
                            break;
                        }
                        if (f.Name == "Consumption" && c.Consumption == int.Parse(f.Value))
                        {
                            result.Add(c);
                            break;
                        }
                    }

                }
                FillCars(result);
            }
            

            
        }
    }
}
