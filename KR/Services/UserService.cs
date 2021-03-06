﻿using KR.Models;
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
            if (File.Exists("Storage/Users.xml"))
            {
                // Десериализуем
                XmlSerializer xs = new XmlSerializer(typeof(List<User>));
                FileStream fs = new FileStream("Storage/Users.xml", FileMode.Open);
                var Users = (List<User>)xs.Deserialize(fs);
                fs.Close();
                return Users;
            }
            else
            {
                return new List<User>();
            }
        }
        public User GetUser(string email, string password, bool save = false)
        {
            var p = Users.Find(u => u.Email == email && u.Password == password);
            if (save)
            {
                SaveUser(p);
            }
            return p;
        }

        public User GetUser()
        {
            if (File.Exists("Storage/User.xml"))
            {
                // Десериализуем
                XmlSerializer xs = new XmlSerializer(typeof(User));
                FileStream fs = new FileStream("Storage/User.xml", FileMode.Open);
                var User = (User)xs.Deserialize(fs);
                fs.Close();
                return User;
            }
            else
            {
                return null;
            }
        }

        public void AddUser(User user)
        {
            Users.Add(user);
            Save();

        }

        public void Update(User user)
        {
            var u = Users.Find(x => x.UserId == user.UserId);
            u.Name = user.Name;
            u.Email = user.Email;
            u.IsAdmin = user.IsAdmin;
            Save();

        }

        public void SaveUser(User user)
        {
            if (File.Exists("Storage/User.xml"))
            {
                File.WriteAllText("Storage/User.xml", "");
            }
            XmlSerializer xs = new XmlSerializer(typeof(User));
            FileStream fs = new FileStream("Storage/User.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, user);
            fs.Close();
        }

        public void Exit()
        {
            if (File.Exists("Storage/User.xml"))
            {
                File.Delete("Storage/User.xml");
            }
        }

        public void Save()
        {
            if (File.Exists("Storage/Users.xml"))
            {
                File.WriteAllText("Storage/Users.xml", "");
            }
            XmlSerializer xs = new XmlSerializer(typeof(List<User>));
            FileStream fs = new FileStream("Storage/Users.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, Users);
            fs.Close();
        }

        public int GetNewUserId()
        {
            return Users.Count;
        }
    }
}
