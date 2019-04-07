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
            if(model.Text == "" ||
                price.Value == 0 ||
                doors.Value==0 ||
                description.Text == "" ||
                consumption.Value == 0 ||
                fuel.Text == "")
            {
                note.Visible = true;
                return;
            }
            Car car = new Car
            {
                CarId = ctrl.GetNewCarId(),
                Model = model.Text,
                Price = price.Value,
                Doors = (int)doors.Value,
                Description = description.Text,
                Consumption = consumption.Value,
                Fuel = fuel.Text
            };
            parent.AddCar(car);
        }

        private void clearNote(object sender = null, EventArgs e = null)
        {
            note.Visible = false;

        }
    }
}
