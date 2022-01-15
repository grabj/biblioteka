using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Book
    {
        private uint _iSBN;
        private string _title;
        private string _authorFirstName;
        private string _authorLastName;
        private int _yearOfRelease;
        private Reader _loaner = null;
        private DateTime _dateOfLoaning;

        public Book(uint iSBN, string title, string authorFirstName, string authorLastName, int yearOfRelease)
        {
            _iSBN = iSBN;
            _title = title;
            _authorFirstName = authorFirstName;
            _authorLastName = authorLastName;
            _yearOfRelease = yearOfRelease;
        }

        public uint ISBN
        { 
            get => _iSBN;
            set => _iSBN = value;
        }
        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public string Author
        {
            get { return $"{ AuthorLastName } { AuthorFirstName }"; }
        }
        public string AuthorFirstName
        {
            get => _authorFirstName;
            set => _authorFirstName = value;
        }
        public string AuthorLastName
        {
            get => _authorLastName;
            set => _authorLastName = value;
        }
        public int YearOfRelease
        {
            get => _yearOfRelease;
            set => _yearOfRelease = value;
        }
        public Reader Loaner
        {
            get => _loaner;
            set => _loaner = value;
        }
        public DateTime DateOfLoaning
        {
            get => _dateOfLoaning;
            set => _dateOfLoaning = value;
        }
    }
}
