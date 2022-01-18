using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ReaderList
    {
        public static List<Reader> Readers = new List<Reader>();

        public static void AddReader(Reader reader)
        {
            Readers.Add(reader);
        }

    }
    class LibrarianList
    {
        public static List<Librarian> Librarians = new List<Librarian>();

        public static void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }
    }
    class BookList
    {
        public static List<Book> Books = new List<Book>();

        public static void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}
