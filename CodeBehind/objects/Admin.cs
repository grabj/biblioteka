using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Admin
    {
        private static Admin instance;

        private Admin(string login = "admin", string password = "admin")
        {
            Password = password;
            Login = login;
        }

        public static Admin GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Admin();
                }
                return instance;
            }
        }

        public string Login { get; }
        public string Password { get; }
    }
}
