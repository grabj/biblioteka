using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    abstract class User
    {
        private string _name;
        private string _surname;
        private string _email;

        public User(string name, string surname, string email)
        {
            _name = name;
            _surname = surname;
            _email = email;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
    }
}
