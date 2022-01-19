using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.data
{
    class helper
    {
        public static void GenerateSampleData()
        {
            Admin admin = Admin.GetInstance;

            Reader[] readers = new Reader[6];
            readers[0] = new Reader("Te", "St", "te@s.t", "test", "test");
            readers[1] = new Reader("Ewa", "Nowak", "EA@wp.pl", "hasło", "Ewa98");
            readers[2] = new Reader("Piotr", "Kot", "Kot@onet.pl", "qwe123!", "kot");
            readers[3] = new Reader("Karol", "Wojtyła", "JP2@gmd.pl", "2137", "JP2");
            readers[4] = new Reader("Róża", "Luksemburg", "Lux@gmail.com", "komunis", "RLux");
            readers[5] = new Reader("Jacek", "Kowalski", "kowal.j@wp.pl", "54531", "Jack01");
            ReaderList.Readers.AddRange(readers);

            Librarian[] librarians = new Librarian[3];
            librarians[0] = new Librarian("Te", "St", "te@s.t", "test2", "test2");
            librarians[1] = new Librarian("Adam", "Filipiak", "FilA@wp.pl", "password", "AFilipiak");
            librarians[2] = new Librarian("Ola", "Ziąbek", "ZiąbekO@gmail.com", "a!rdS", "OZiabek");
            LibrarianList.Librarians.AddRange(librarians);

            Book[] books = new Book[6];
            books[0] = new Book("9808-7685-0978", "Germinal", "Emil", "Zola");
            books[1] = new Book("2132-2144-1412", "C#. Kurs", "Marcin", "Lis");
            books[2] = new Book("1312-1312-0161", "Pomoc Wzajemna", "Pjotr", "Kropotkin");
            books[3] = new Book("5675-8793-4357", "Fale", "Virginia", "Woolf");
            books[4] = new Book("3345-3453-4535", "Upadek", "Albert", "Camus");
            books[5] = new Book("2137-1312-2392", "Głos Pana", "Lem", "Stanisław");
            BookList.Books.AddRange(books);
        }
    }
}
