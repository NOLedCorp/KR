using KR.Models;
using KR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Controllers
{
    public class RentCarController
    {
        private UserService us = new UserService();
        private CarService cs = new CarService();
        private BookService bs = new BookService();
        public void Add(User user)
        {
            us.AddUser(user);
        }
        public User GetUser(string email, string password, bool save = false)
        {
            return us.GetUser(email, password, save);
        }

        public User GetU()
        {
            return us.GetUser();
        }

        public List<Book> GetBooks()
        {
            return bs.Get();
        }

        public int GetNewUserId()
        {
            return us.GetNewUserId();
        }

        public void Exit()
        {
            us.Exit();
        }
        public int GetNewReportId()
        {
            return cs.GetNewReportId();
        }
        public void Add(Report r)
        {
            cs.AddReport(r);
        }
        public List<Report> GetReports()
        {
            return cs.GetReports();
        }
        public List<Report> GetCarReports(int CarId)
        {
            return cs.GetCarReports(CarId);
        }

        public List<int> GetCarMarks(int CarId)
        {
            return cs.GetCarMarks(CarId);
        }

        public void Add(Car c)
        {
            cs.AddCar(c);
        }
        public int GetNewCarId()
        {
            return cs.GetNewCarId();
        }
        public List<Car> GetCars()
        {
            return cs.GetCars();
        }
        public int GetNewBookId()
        {
            return bs.GetNewBookId();
        }
        public void Add(Book book)
        {
            bs.Add(book);
        }
        public void Update(Book book)
        {
            bs.Update(book);
        }
        public void Update(Car car)
        {
            cs.Update(car);
        }
        public void Remove(Book book)
        {
            bs.Remove(book);
        }
        public void Remove(Car car)
        {
            cs.Remove(car);
        }
        public List<Book> GetUserBooks(int UserId)
        {
            return bs.GetUserBooks(UserId);
        }
    }
}
