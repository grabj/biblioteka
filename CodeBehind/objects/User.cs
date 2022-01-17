using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public abstract class User
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private string _login;

        public User(string firstName, string lastName, string email, string password, string login)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _password = password;
            _login = login;
        }

        public string Login
        {
            get => _login;
            set => _login = value;
        }
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }
    }
}
