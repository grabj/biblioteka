﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Projekt
{
    class ReaderList
    {
        public static List<Reader> Readers = new List<Reader>();

        public static void AddReader(Reader reader)
        {
            Readers.Add(reader);
        }
        public static void RemoveReader(uint ID)
        {
            Readers.RemoveAll(Readers => Readers.ID == ID);
        }
    }
    class LibrarianList
    {
        public static List<Librarian> Librarians = new List<Librarian>();

        public static void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }
        public static void RemoveLibrarian(uint ID)
        {
            Librarians.RemoveAll(Librarians => Librarians.ID == ID);
        }
    }
    class BookList
    {
        public static List<Book> Books = new List<Book>();

        public static void AddBook(Book book)
        {
            Books.Add(book);
        }
        public static void RemoveBook(uint ID)
        {
            Books.RemoveAll(Books => Books.BookID == ID);
        }
    }
    class LoanList
    {
        public static List<Loan> Loans = new List<Loan>();

        public static void AddLoan(Loan loan)
        {
            Loans.Add(loan);
        }
        public static void RemoveLoan(uint ID)
        {
            Loans.RemoveAll(Loans => Loans.ID == ID);
        }
    }
}
