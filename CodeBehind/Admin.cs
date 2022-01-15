using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Admin : User
    {
        public Admin(uint id = 1, string name = "admin", string surname = null, string email = null, string password = "admin") : base(name, surname, email)
        {
            ID = id;
            Login = name + ID;
            Password = password;
        }

        public uint ID { get; }
        public string Login { get; }
        public string Password { get; }

    }
}
