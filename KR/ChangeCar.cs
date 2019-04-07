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
    public partial class ChangeCar : Form
    {
        public Cars parent { get; set; }
        public Car car { get; set; }
        public ChangeCar(Cars parent, Car car)
        {
            this.parent = parent;
            this.car = car;
            InitializeComponent();
            model.Text = car.Model;
            price.Value = car.Price;
            doors.Value = car.Doors;
            consumption.Value = car.Consumption;
            fuel.Text = car.Fuel;
            description.Text = car.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (model.Text == "" ||
                price.Value == 0 ||
                doors.Value == 0 ||
                description.Text == "" ||
                consumption.Value == 0 ||
                fuel.Text == "")
            {
                note.Visible = true;
                return;
            }
            car.Model = model.Text;
            car.Price = price.Value;
            car.Doors = (int)doors.Value;
            car.Consumption = consumption.Value;
            car.Fuel = fuel.Text;
            car.Description = description.Text;
            parent.parent.ctrl.Update(car);
            parent.CloseCarForm();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.parent.ctrl.Remove(car);
            parent.CloseCarForm();
        }
        private void clearNote(object sender = null, EventArgs e = null)
        {
            note.Visible = false;

        }
    }
}
