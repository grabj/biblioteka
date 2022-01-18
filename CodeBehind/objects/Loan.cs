using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Loan
    {
        private readonly ReaderList _readers;
        private readonly BookList _books;

        private uint _numOfLoans;
        private DateTime _dateOfLoan;
        private Reader _loaner;
        private Book _book;

        public Loan(DateTime dateOfLoan, Reader loaner, Book book)
        {
            loaner.BookCount++;
            book.IsAvailable = false;
            _dateOfLoan = dateOfLoan;
            DateOfReturn = dateOfLoan.AddDays(30);
            book.DateOfReturning = DateOfReturn;
            _loaner = loaner;
            _book = book;
            _numOfLoans++;
            ID = _numOfLoans;
        }

        public uint ID { get; }
        public Reader Loaner
        {
            get => _loaner;
            set => _loaner = value;
        }
        public Book book
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


    }
}
