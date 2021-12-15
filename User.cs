using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class User
    {
        private static uint _numOfUsers;
        public static uint NumOfClients => _numOfUsers;

        private uint _ID;
        private string _name;
        private string _surname;
        private string _email;
        private DateTime _dateOfBirth;

        public uint ID
        {
            get => _ID;
            set => _ID = value;
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
        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => _dateOfBirth = value;
        }

        public User()
        {
            _numOfUsers++;
            this.ID = _numOfUsers;
        }
        public User(int iD, string name, string surname, string email, DateTime dateOfBirth)
        {
            _numOfUsers++;
            this.ID = _numOfUsers;
            _name = name;
            _surname = surname;
            _email = email;
            _dateOfBirth = dateOfBirth;
        }
    }
}
