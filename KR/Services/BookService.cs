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
            Books = GetBooks();
        }

        public List<Book> GetBooks()
        {
            if (File.Exists("Books.xml"))
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

        public void AddBook(Book book)
        {
            Books.Add(book);
            XmlSerializer xs = new XmlSerializer(typeof(List<Book>));
            FileStream fs = new FileStream("Books.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, Books);
            fs.Close();

        }

        public int GetNewBookId()
        {
            return Books.Count;
        }
    }
}
