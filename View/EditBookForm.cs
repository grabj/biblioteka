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
    public partial class EditBookForm : Form
    {
        public EditBookForm()
        {
            InitializeComponent();
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            textBox5.Text = _editID.ToString();
            textBox5.Enabled = false;

            textBox2.Text = bookToEdit.Title;
            textBox1.Text = bookToEdit.AuthorFirstName;
            textBox3.Text = bookToEdit.AuthorLastName;
            textBox4.Text = bookToEdit.ISBN;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                bookToEdit.Title = textBox2.Text;
                bookToEdit.AuthorFirstName = textBox1.Text;
                bookToEdit.AuthorLastName = textBox3.Text;
                bookToEdit.ISBN = textBox4.Text;

                MessageBox.Show("Dane książki zostały zmienione.", "OK");
                Globals.form.Refresh_Menu();
                this.Close();
            }
            else
            {
                label6.Text = "Pola nie mogą być puste!";
                label6.ForeColor = Color.DarkRed;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void FindBook(string ID)
        {
            _bookID = Convert.ToUInt32(ID);
            BookList.Books.ForEach(delegate (Book book)
            {
                if (book.BookID == _bookID)
                {
                    _editID = _bookID;
                    bookToEdit = book;
                }
            });

        }
        private uint _editID;
        private uint _bookID;
        private Book bookToEdit;
    }
}
