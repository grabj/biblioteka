using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.View
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Uzupełnij informacje", "Niepowodzenie!");
            }
            else
            {
                Book book = new Book(textBox4.Text, textBox2.Text, textBox1.Text, textBox3.Text);

                BookList.AddBook(book);

                string info = $"\nID: {book.BookID}\nTytuł: {book.Title}\nAutor: {book.Author}\nNr ISBN: {book.ISBN}";

                MessageBox.Show("Dodano nową książkę o danych:" + info, "Sukces!");
                Globals.form.Refresh_Menu();
                this.Hide();
            }
        }
    }
}
