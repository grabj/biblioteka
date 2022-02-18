using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Projekt
{
    [Serializable()]
    public class Loan
    {
        [field: NonSerialized()]
        private static uint _numOfLoans = 0;
        [field: NonSerialized()]
        private DateTime _dateOfLoan;
        [field: NonSerialized()]
        private Reader _loaner;
        [field: NonSerialized()]
        private Book _book;

        public Loan()
        {
            _numOfLoans++;
            DateOfReturn = _dateOfLoan.AddDays(30);
            ID = _numOfLoans;
            LoanerID = 0;
            BookID = 0;
            _dateOfLoan = default;
        }

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
            //Loaner.BookCount--;

            DateOfLoan = default;
            DateOfReturn = default;

            BookList.Books.ForEach(delegate (Book book)
            {
                if (book.BookID == BookID)
                {
                    book.IsAvailable = true;
                    book.DateOfReturning = default;
                }
            });
        }

        public uint ID { get; set; }
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
        public DateTime DateOfReturn { get; set; }
        public uint LoanerID { get; set; }
        public uint BookID { get; set; }
    }
}
