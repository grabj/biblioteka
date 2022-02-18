using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Projekt
{
    [Serializable()]
    public class Book
    {
        [field: NonSerialized]
        private static uint numOfBooks;
        [field: NonSerialized]
        private string _iSBN;
        [field: NonSerialized]
        private string _title;
        [field: NonSerialized]
        private string _authorFirstName;
        [field: NonSerialized]
        private string _authorLastName;
        [field: NonSerialized]
        private DateTime _dateOfReturning;
        [field: NonSerialized]
        private bool _isAvailable = true;

        public Book()
        {
            _iSBN = null;
            _title = null;
            _authorFirstName = null;
            _authorLastName = null;
            numOfBooks++;
            BookID = numOfBooks;
            IsAvailable = true;
            DateOfReturning = default;
        }

        public Book(string iSBN, string title, string authorFirstName, string authorLastName)
        {
            _iSBN = iSBN;
            _title = title;
            _authorFirstName = authorFirstName;
            _authorLastName = authorLastName;
            numOfBooks++;
            BookID = numOfBooks;
        }

        public uint BookID { get; set; }
        public string ISBN
        { 
            get => _iSBN;
            set => _iSBN = value;
        }
        public string Title
        {
            get => _title;
            set => _title = value;
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
        public DateTime DateOfReturning
        {
            get => _dateOfReturning;
            set => _dateOfReturning = value;
        }
        public bool IsAvailable
        {
            get => _isAvailable;
            set => _isAvailable = value;
        }
        public string Author
        {
            get { return $"{ AuthorLastName } { AuthorFirstName }"; }
        }
    }
}
