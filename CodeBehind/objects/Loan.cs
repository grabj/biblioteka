using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Loan
    {
        private static uint _numOfLoans = 0;

        private DateTime _dateOfLoan;
        private Reader _loaner;
        private Book _book;

        public Loan(DateTime dateOfLoan, Reader loaner, Book book)
        {
            _numOfLoans++;
            loaner.BookCount++;
            book.IsAvailable = false;
            _dateOfLoan = dateOfLoan;
            DateOfReturn = dateOfLoan.AddDays(30);
            book.DateOfReturning = DateOfReturn;
            _loaner = loaner;
            _book = book;
            ID = _numOfLoans;
            LoanerID = _loaner.ID;
            BookID = _book.BookID;
        }

        public void ReturnBook()
        {
            Loaner.BookCount--;
            Book.IsAvailable = true;
            Book.DateOfReturning = default;
            DateOfLoan = default;
        }

        public uint ID { get; }
        public Reader Loaner
        {
            get => _loaner;
            set => _loaner = value;
        }
        public Book Book
        {
            get => _book;
            set => _book = value;
        }
        public DateTime DateOfLoan
        {
            get => _dateOfLoan;
            set => _dateOfLoan = value;
        }
        public DateTime DateOfReturn { get; }
        public uint LoanerID { get; }
        public uint BookID { get; }
    }
}
