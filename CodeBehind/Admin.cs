using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Admin : User
    {
        public Admin(uint id = 1, string lastName = "admin", string firstName = null, string email = null, string password = "admin") : base(lastName, firstName, email)
        {
            ID = id;
            Login = lastName + ID;
            Password = password;
        }

        public uint ID { get; }
        public string Login { get; }
        public string Password { get; }

    }
}
