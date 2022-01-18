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
            dataGridView2.DataSource = ReaderList.Readers;
            dataGridView3.DataSource = LibrarianList.Librarians;
            dataGridView1.DataSource = BookList.Books; 
        }
        public virtual void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInView logInView1 = new LogInView();
            this.Dispose();
            logInView1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public virtual void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zalogowano jako admin", "Stan konta");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            View.SignupForm signupForm = new View.SignupForm();
            signupForm.Show();
        }

        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.SignupForm signupForm = new View.SignupForm();
            signupForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            View.ConfirmForm confirmForm = new View.ConfirmForm();
            confirmForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            View.ConfirmForm confirmForm = new View.ConfirmForm();
            confirmForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            View.AddBookForm addBookForm = new View.AddBookForm();
            addBookForm.Show();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = ReaderList.Readers;
            dataGridView2.Update();
            dataGridView2.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();
            dataGridView3.DataSource = ReaderList.Readers;
            dataGridView3.Update();
            dataGridView3.Refresh();
        }
    }
}
