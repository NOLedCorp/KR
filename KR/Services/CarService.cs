using KR.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KR.Services
{
    class CarService
    {
        public List<Report> Reports { get; set; }
        public List<Car> Cars { get; set; }
        public CarService()
        {
            Reports = GetReports();
            Cars = GetCars();
        }
        public List<Report> GetReports()
        {
            if (File.Exists("../../../Reports.xml"))
            {
                // Десериализуем
                XmlSerializer xs = new XmlSerializer(typeof(List<Report>));
                FileStream fs = new FileStream("../../../Reports.xml", FileMode.Open);
                var Reports = (List<Report>)xs.Deserialize(fs);
                fs.Close();
                return Reports;
            }
            else
            {
                return new List<Report>();
            }
        }

        public List<Report> GetCarReports(int CarId)
        {
            return Reports.FindAll(r => r.Car.CarId == CarId);
        }

        public List<int> GetCarMarks(int CarId)
        {
            return Reports.FindAll(r => r.Car.CarId == CarId).Select(r => r.Mark).ToList();
        }

        public List<Car> GetCars()
        {
            if (File.Exists("../../../Cars.xml"))
            {
                // Десериализуем
                XmlSerializer xs = new XmlSerializer(typeof(List<Car>));
                FileStream fs = new FileStream("../../../Cars.xml", FileMode.Open);
                var Cars = (List<Car>)xs.Deserialize(fs);
                fs.Close();
                return Cars;
            }
            else
            {
                return new List<Car>();
            }
        }
        public void AddReport(Report report)
        {
            Reports.Add(report);

            SaveReports();
        }

        public void Update(Car car)
        {
            var c = Cars.Find(x => x.CarId == car.CarId);
            c.Model = car.Model;
            c.Price = car.Price;
            c.Doors = car.Doors;
            c.Consumption = car.Consumption;
            c.Fuel = car.Fuel;
            c.Description = car.Description;
            Save();
        }

        public int GetNewReportId()
        {
            return Reports.Count;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
            Save();

        }

        private void Save()
        {
            if (File.Exists("../../../Cars.xml"))
            {
                File.WriteAllText("../../../Cars.xml", "");
            }
            XmlSerializer xs = new XmlSerializer(typeof(List<Car>));
            FileStream fs = new FileStream("../../../Cars.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, Cars);
            fs.Close();
        }
        private void SaveReports()
        {
            if (File.Exists("../../../Reports.xml"))
            {
                File.WriteAllText("../../../Reports.xml", "");
            }
            XmlSerializer xs = new XmlSerializer(typeof(List<Report>));
            FileStream fs = new FileStream("../../../Reports.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, Reports);
            fs.Close();
        }

        public void Remove(Car car)
        {
            var i = Cars.Select(x => x.CarId).ToList().IndexOf(car.CarId);
            Cars.RemoveAt(i);
            Save();
        }

        public int GetNewCarId()
        {
            return Cars.Count;
        }
    }
}
