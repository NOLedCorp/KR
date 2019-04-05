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
        private ChangeCar chCarForm;
        private List<Filter> filters = new List<Filter>();
        private string SortType = "Цена";
        private bool SortDir = true;
        public Cars(RentCarController ctrl, Form1 parent)
        {
            this.ctrl = ctrl;
            this.parent = parent;
            InitializeComponent();
            label1.TextAlign = ContentAlignment.MiddleCenter;
            cars = ctrl.GetCars();
            comboBox1.Text = "Цена";
            radioButton1.Checked = true;
            Sort();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changeSortType(object sender, EventArgs e)
        {
            SortType = comboBox1.Text;
            Sort();
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
                if (parent.user.IsAdmin)
                {
                    chCarForm = new ChangeCar(this, cars[e.RowIndex]);
                    chCarForm.Show();
                }
                else
                {
                    bookForm = new BookForm(this, cars[e.RowIndex]);
                    bookForm.Show();
                }
                
            }
        }

        public void CloseForm()
        {
            bookForm.Hide();
        }
        public void CloseCarForm()
        {
            FillCars(cars = ctrl.GetCars());
            chCarForm.Hide();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SortDir = true;
            Sort();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SortDir = false;
            Sort();
        }

        private void Sort()
        {
            switch (SortType)
            {
                case "Цена":
                    {
                        if (SortDir)
                        {
                            FillCars(cars.OrderBy(x => x.Price).ToList());
                        }
                        else
                        {
                            FillCars(cars.OrderByDescending(x => x.Price).ToList());
                        }
                        
                        break;
                    }
                case "Модель":
                    {
                        if (SortDir)
                        {
                            FillCars(cars.OrderBy(x => x.Model).ToList());
                        }
                        else
                        {
                            FillCars(cars.OrderByDescending(x => x.Model).ToList());
                        }

                        break;
                    }
                case "Расход":
                    {
                        if (SortDir)
                        {
                            FillCars(cars.OrderBy(x => x.Consumption).ToList());
                        }
                        else
                        {
                            FillCars(cars.OrderByDescending(x => x.Consumption).ToList());
                        }

                        break;
                    }
                case "Двери":
                    {
                        if (SortDir)
                        {
                            FillCars(cars.OrderBy(x => x.Doors).ToList());
                        }
                        else
                        {
                            FillCars(cars.OrderByDescending(x => x.Doors).ToList());
                        }

                        break;
                    }

            }
        }
    }
}
