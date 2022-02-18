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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label1.Text = "";
            }
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
                        ActiveReader = reader;
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
                label1.Text = "Podano błędny login lub hasło";
                label1.ForeColor = Color.DarkRed;
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
        public static Reader ActiveReader = null;

        private void LogInView_Load(object sender, EventArgs e)
        {

        }

        private void LogInView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
