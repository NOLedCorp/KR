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
    public partial class CarForm : Form
    {
        public Profile parent;
        public RentCarController ctrl;
        public CarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car
            {
                CarId = ctrl.GetNewCarId(),
                Model = model.Text,
                Price = double.Parse(price.Text),
                Doors = (int)doors.Value,
                Description = description.Text,
                Consumption = int.Parse(consumption.Text),
                Fuel = fuel.Text
            };
            parent.AddCar(car);
        }
    }
}
