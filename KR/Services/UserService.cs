using KR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace KR.Services
{
    class UserService
    {
        public List<User> Users { get; set; }
        public UserService()
        {
            Users = GetUsers();
        }

        public List<User> GetUsers()
        {
            if (File.Exists("Users.xml"))
            {
                // Десериализуем
                XmlSerializer xs = new XmlSerializer(typeof(List<User>));
                FileStream fs = new FileStream("Users.xml", FileMode.Open);
                var Users = (List<User>)xs.Deserialize(fs);
                fs.Close();
                return Users;
            }
            else
            {
                return new List<User>();
            }
        }
        public User GetUser(string email, string password)
        {
            var p = Users.Find(u => u.Email == email && u.Password == password);
            return p;
        }

        public void AddUser(User user)
        {
            Users.Add(user);
            Save();

        }

        public void Save()
        {
            if (File.Exists("Users.xml"))
            {
                File.WriteAllText("Users.xml", "");
            }
            XmlSerializer xs = new XmlSerializer(typeof(List<User>));
            FileStream fs = new FileStream("Users.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, Users);
            fs.Close();
        }

        public int GetNewUserId()
        {
            return Users.Count;
        }
    }
}
