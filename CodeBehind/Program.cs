using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Projekt
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists("./data/BooksData.xml"))
            {
                data.Xml.DeserializeBook(BookList.Books, "./data/BooksData.xml");
                data.Xml.DeserializeReader(ReaderList.Readers, "./data/ReadersData.xml");
                data.Xml.DeserializeLibrarian(LibrarianList.Librarians, "./data/LibrariansData.xml");
                data.Xml.DeserializeLoan(LoanList.Loans, "./data/LoansData.xml");
            }
            if (BookList.Books.Count <= 1)
            {
                data.helper.GenerateSampleData();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LogInView());

            data.Xml.SerializeBook(BookList.Books, "./data/BooksData.xml");
            data.Xml.SerializeReader(ReaderList.Readers, "./data/ReadersData.xml");
            data.Xml.SerializeLibrarian(LibrarianList.Librarians, "./data/LibrariansData.xml");
            data.Xml.SerializeLoan(LoanList.Loans, "./data/LoansData.xml");
        }
    }
}
