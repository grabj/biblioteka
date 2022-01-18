using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Book
    {
        private static uint numOfBooks;
        private string _iSBN;
        private string _title;
        private string _authorFirstName;
        private string _authorLastName;
        private uint _loanerID;
        private DateTime _dateOfLoaning;
        private DateTime _dateOfReturning;
        private bool _isAvailable = true;

        public Book(string iSBN, string title, string authorFirstName, string authorLastName)
        {
            _iSBN = iSBN;
            _title = title;
            _authorFirstName = authorFirstName;
            _authorLastName = authorLastName;
            numOfBooks++;
            BookID = numOfBooks;
        }

        public void Loan(DateTime dateOfLoaning, Reader loaner)
        {
            loaner.BookCount++;
            _dateOfLoaning = dateOfLoaning;
            _dateOfReturning = dateOfLoaning.AddDays(30);
            _loanerID = loaner.ID;
        }

        public uint BookID { get; }
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
        public uint LoanerID
        {
            get => _loanerID;
            set => _loanerID = value;
        }
        public DateTime DateOfLoaning
        {
            get => _dateOfLoaning;
            set => _dateOfLoaning = value;
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
    }
}
