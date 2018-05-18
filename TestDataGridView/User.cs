using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGridView
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string Function { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public User()
        {
        }

        public User(int id, string name, string surname, string address, string function, string login, string password)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Address = address;
            Function = function;
            Login = login;
            Password = password;
        }
    }
}
