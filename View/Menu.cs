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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            dataGridView1.DataSource = BookList.Books;
            dataGridView2.DataSource = ReaderList.Readers;
            dataGridView3.DataSource = LibrarianList.Librarians;
            dataGridView4.DataSource = LoanList.Loans;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View.ReturnForm returnForm = new View.ReturnForm();
            returnForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInView logInView1 = new LogInView();
            this.Dispose();
            LogInView.ActiveReader = null;
            logInView1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public virtual void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zalogowano jako Administrator.", "Stan konta");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            View.SignupForm signupForm = new View.SignupForm();
            signupForm.user_Type(2);
            signupForm.Show();
        }

        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.SignupForm signupForm = new View.SignupForm();
            signupForm.user_Type(2);
            signupForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            View.SignupForm signupForm = new View.SignupForm();
            signupForm.user_Type(1);
            signupForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View.AddBookForm addBook = new View.AddBookForm();
            addBook.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Refresh_Menu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Refresh_Menu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Refresh_Menu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Refresh_Menu();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            View.LoanForm loanForm = new View.LoanForm();
            loanForm.FindBook(dataGridView1.SelectedCells[0].Value.ToString());
            loanForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                View.EditBookForm editBook = new View.EditBookForm();
                editBook.FindBook(dataGridView1.SelectedCells[0].Value.ToString());
                editBook.Show();
            }
            else
                MessageBox.Show("Wybierz książkę do edycji.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                View.ConfirmDeleteBook confirmDeleteBook = new View.ConfirmDeleteBook();
                confirmDeleteBook.FindBook(dataGridView1.SelectedCells[0].Value.ToString());
                confirmDeleteBook.Show();
            }
            else
                MessageBox.Show("Wybierz książkę do usunięcia.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                View.ConfirmDeleteLibrarian confirmDeleteLibrarian = new View.ConfirmDeleteLibrarian();
                confirmDeleteLibrarian.FindLibrarian(dataGridView3.SelectedCells[0].Value.ToString());
                confirmDeleteLibrarian.Show();
            }
            else
                MessageBox.Show("Wybierz użytkownika do usunięcia.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                View.ConfirmDeleteReader confirmDeleteReader = new View.ConfirmDeleteReader();
                confirmDeleteReader.FindReader(dataGridView2.SelectedCells[0].Value.ToString());
                confirmDeleteReader.Show();
            }
            else
                MessageBox.Show("Wybierz użytkownika do usunięcia.");
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            Globals.form = this;
        }

        public void Refresh_Menu()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = BookList.Books;
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = ReaderList.Readers;
            dataGridView2.Update();
            dataGridView2.Refresh();
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();
            dataGridView3.DataSource = LibrarianList.Librarians;
            dataGridView3.Update();
            dataGridView3.Refresh();
            dataGridView4.DataSource = null;
            dataGridView4.Rows.Clear();
            dataGridView4.DataSource = LoanList.Loans;
            dataGridView4.Update();
            dataGridView4.Refresh();
        }
    }

    class Globals
    {
        public static Menu form;
    }
}
