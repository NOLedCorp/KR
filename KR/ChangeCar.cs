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
            price.Text = car.Price.ToString();
            doors.Value = car.Doors;
            consumption.Text = car.Consumption.ToString();
            fuel.Text = car.Fuel;
            description.Text = car.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            car.Model = model.Text;
            car.Price = double.Parse(price.Text);
            car.Doors = (int)doors.Value;
            car.Consumption = int.Parse(consumption.Text);
            car.Fuel = fuel.Text;
            car.Description = description.Text;


        }
    }
}
