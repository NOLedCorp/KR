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
    public partial class Statistics : Form
    {
        private RentCarController _ctrl = new RentCarController();
        private List<Car> _cars;
        private List<Book> _books;
        private List<Profit> _profits;
        private List<CarRating> _ratingCars;
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month+1, 1);
            _cars = _ctrl.GetCars();
            _ratingCars = _cars.Select(x => new CarRating { Model = x.Model, ReportsNumber = _ctrl.GetCarReports(x.CarId).Count, Mark = GetCarMark(x.CarId) }).OrderByDescending(x => x.Mark).ToList();
            
            for(int i = 0; i<_ratingCars.Count; i++)
            {
                _ratingCars[i].Id = i + 1;
            }
            carRatingBindingSource.DataSource = _ratingCars;
            _books = _ctrl.GetBooks();
            ReloadProfits();

        }

        private void ReloadProfits(object sender = null, EventArgs e = null)
        {
            if(_books != null)
            {
                if (dateTimePicker2.Value < dateTimePicker1.Value)
                {
                    var t = dateTimePicker2.Value;
                    dateTimePicker2.Value = dateTimePicker1.Value;
                    dateTimePicker1.Value = t;
                }
                _profits = _books.FindAll(x => x.DateStart < dateTimePicker2.Value && x.DateStart > dateTimePicker1.Value).Select(x => new Profit { Id = x.BookId, ClientName = x.User.Name, DateFinish = x.DateFinish, DateStart = x.DateStart, Model = x.Car.Model, Sum = x.Car.Price * (x.DateFinish - x.DateStart).Days }).ToList();
                profitBindingSource.DataSource = _profits;
                label3.Text = _ctrl.GetB().Where(x => x.DateStart < dateTimePicker2.Value && x.DateStart > dateTimePicker1.Value).Select(x => x.Car.Price * (x.DateFinish - x.DateStart).Days).Sum().ToString();

            }
            
        }

        private void carRatingBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void profit_Enter(object sender, EventArgs e)
        {

        }

        private double GetCarMark(int CarId)
        {
            var rr = _ctrl.GetCarMarks(CarId);
            if(rr.Count > 0)
            {
                return rr.Average();
            }
            else
            {
                return 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ctrl.Export(_ratingCars);
        }
    }
}
