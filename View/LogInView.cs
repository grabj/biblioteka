using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class LogInView : Form
    {
        public LogInView()
        {
            InitializeComponent();
            Reader user1 = new Reader("Ewa", "Nowak", "EA@wp.pl", "Nowak", "en");
            ReaderList.AddReader(user1);

            Librarian user2 = new Librarian("Adam", "Filipiak", "FilA@wp.pl", "Fil", "af");
            LibrarianList.AddLibrarian(user2);

            Book book1 = new Book("3453-4353-86785", "Upadek", "Albert", "Camus");
            BookList.AddBook(book1);
            Book book2 = new Book("6767-64547-5435", "Po Piśmie", "Jacek", "Dukaj");
            book2.IsAvailable = false;
            BookList.AddBook(book2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuGuestView menuGuest = new MenuGuestView();
            this.Hide();
            menuGuest.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = Admin.GetInstance;

            Menu menuAdmin = new Menu();
            MenuReaderView menuReader = new MenuReaderView();
            MenuLibrarianView menuLibrarian = new MenuLibrarianView();

            if (Validate(admin.Login, admin.Password))
            {
                menuAdmin.Show();
                this.Hide();
            }
            else
            {
                foreach (var reader in ReaderList.Readers)
                {
                    if (Validate(reader.Login, reader.Password))
                    {
                        menuReader.Show();
                        this.Hide();
                    }
                }
                foreach (var librarian in LibrarianList.Librarians)
                {
                    if (Validate(librarian.Login, librarian.Password))
                    {
                        menuLibrarian.Show();
                        this.Hide();
                    }
                }
                this.Hide();
            }
            //menuAdmin.Show();
            this.Hide();
        }
        private bool Validate(string login, string password)
        {
            bool valid = false;
            if (textBox1.Text == login && textBox2.Text == password)
                valid = true;
            return valid;
        }
    }
}
