﻿using KR.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KR.Services
{
    class BookService
    {
        public List<Book> Books;

        public BookService()
        {
            Books = Get();
        }

        public List<Book> Get()
        {
            if (File.Exists("Storage/Books.xml"))
            {
                // Десериализуем
                XmlSerializer xs = new XmlSerializer(typeof(List<Book>));
                FileStream fs = new FileStream("Storage/Books.xml", FileMode.Open);
                var Books = (List<Book>)xs.Deserialize(fs);
                fs.Close();
                return Books;
            }
            else
            {
                return new List<Book>();
            }
        }

        public List<Book> GetCarBooks(int carId)
        {
            return Books.FindAll(b => b.Car.CarId == carId);
        }

        public List<Book> GetUserBooks(int userId)
        {
            return Books.FindAll(b => b.User.UserId == userId);
        }

        public void Add(Book book)
        {
            Books.Add(book);
            Save();

        }

        public bool CheckCarBook(DateTime dateStart, DateTime dateFinish, int carId)
        {
            var books = GetCarBooks(carId);
            foreach(Book b in books)
            {
                if(b.DateStart<dateStart && b.DateFinish > dateStart)
                {
                    return false;
                }
                if (b.DateStart < dateFinish && b.DateFinish > dateStart)
                {
                    return false;
                }
            }
            return true;
        }

        public void Update(Book book)
        {
            Book b = Books.Find(x => x.BookId == book.BookId);
            b.DateStart = book.DateStart;
            b.DateFinish = book.DateFinish;
            Save();
           

        }
        public void Remove(Book book)
        {
            Books.Remove(book);
            Save();

        }
        private void Save()
        {
            if (File.Exists("Storage/Books.xml"))
            {
                File.WriteAllText("Storage/Books.xml", "");
            }
            XmlSerializer xs = new XmlSerializer(typeof(List<Book>));
            FileStream fs = new FileStream("Storage/Books.xml", FileMode.OpenOrCreate);
            
            xs.Serialize(fs, Books);
            fs.Close();
        }

        public int GetNewBookId()
        {
            return Books.Count;
        }
    }
}
