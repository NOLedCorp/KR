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
            if (File.Exists("Reports.xml"))
            {
                // Десериализуем
                XmlSerializer xs = new XmlSerializer(typeof(List<Report>));
                FileStream fs = new FileStream("Reports.xml", FileMode.Open);
                var Reports = (List<Report>)xs.Deserialize(fs);
                fs.Close();
                return Reports;
            }
            else
            {
                return new List<Report>();
            }
        }
        public List<Car> GetCars()
        {
            if (File.Exists("Cars.xml"))
            {
                // Десериализуем
                XmlSerializer xs = new XmlSerializer(typeof(List<Car>));
                FileStream fs = new FileStream("Cars.xml", FileMode.Open);
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
            XmlSerializer xs = new XmlSerializer(typeof(List<Report>));
            FileStream fs = new FileStream("Reports.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, Reports);
            fs.Close();

        }

        public int GetNewReportId()
        {
            return Reports.Count;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
            XmlSerializer xs = new XmlSerializer(typeof(List<Car>));
            FileStream fs = new FileStream("Cars.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, Cars);
            fs.Close();

        }

        public int GetNewCarId()
        {
            return Cars.Count;
        }
    }
}
