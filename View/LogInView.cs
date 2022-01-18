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

            Librarian user2 = new Librarian("Adam", "Filipiak", "FilA@wp.pl", "Filipiak", "af");
            LibrarianList.AddLibrarian(user2);

            Book book1 = new Book(34534535, "Obcy", "Albert", "Camus");
            BookList.AddBook(book1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
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
            View.MenuReaderForm menuReaderForm = new View.MenuReaderForm();
            View.MenuLibrarianForm menuLibrarianForm = new View.MenuLibrarianForm();

            while (true)
            {
                if (Validate(admin.Login, admin.Password))
                {
                    menuAdmin.Show();
                    this.Hide();
                    break;
                }
                foreach (var reader in ReaderList.Readers)
                {
                    if (Validate(reader.Login, reader.Password))
                    {
                        menuReaderForm.Show();
                        this.Hide();
                        break;
                    }
                }
                foreach (var librarian in LibrarianList.Librarians)
                {
                    if (Validate(librarian.Login, librarian.Password))
                    {
                        menuLibrarianForm.Show();
                        this.Hide();
                        break;
                    }
                }
                MessageBox.Show("Podano błędny login lub błędne hasło");
                break;
            }
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
