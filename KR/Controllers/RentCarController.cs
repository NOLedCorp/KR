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
        public User GetUser(string email, string password)
        {
            return us.GetUser(email, password);
        }

        public int GetNewUserId()
        {
            return us.GetNewUserId();
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
        public void Remove(Book book)
        {
            bs.Remove(book);
        }
        public List<Book> GetUserBooks(int UserId)
        {
            return bs.GetUserBooks(UserId);
        }
    }
}
