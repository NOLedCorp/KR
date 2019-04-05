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
    class BookService
    {
        public List<Book> Books;

        public BookService()
        {
            Books = Get();
        }

        public List<Book> Get()
        {
            if (File.Exists("../../../Books.xml"))
            {
                // Десериализуем
                XmlSerializer xs = new XmlSerializer(typeof(List<Book>));
                FileStream fs = new FileStream("Books.xml", FileMode.Open);
                var Books = (List<Book>)xs.Deserialize(fs);
                fs.Close();
                return Books;
            }
            else
            {
                return new List<Book>();
            }
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
            if (File.Exists("../../../Books.xml"))
            {
                File.WriteAllText("../../../Books.xml", "");
            }
            XmlSerializer xs = new XmlSerializer(typeof(List<Book>));
            FileStream fs = new FileStream("../../../Books.xml", FileMode.OpenOrCreate);
            
            xs.Serialize(fs, Books);
            fs.Close();
        }

        public int GetNewBookId()
        {
            return Books.Count;
        }
    }
}
