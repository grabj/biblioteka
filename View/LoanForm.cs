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
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {

            textBox1.Enabled = true;

            if (LogInView.ActiveReader != null)
            {
                loaner = LogInView.ActiveReader;

                textBox1.Text = loaner.ID.ToString();
                textBox1.Enabled = false;

                labelLoaner.Text = loaner.FirstName + " " + loaner.LastName;
            }

            labelDate1.Text = DateTime.Today.ToShortDateString();
            labelDate2.Text = DateTime.Today.AddDays(30).ToShortDateString();

            labelBook.Text = "\"" + bookL.Title + "\"";
            textBox2.Text = _bookID.ToString();
            textBox2.Enabled = false;
        }

        public void FindBook(string ID)
        {
            _bookID = Convert.ToUInt32(ID);
            BookList.Books.ForEach(delegate (Book book)
            {
                if (book.BookID == _bookID)
                {
                    bookL = book;
                }
            });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var reader in ReaderList.Readers)
            {
                if (textBox1.Text == reader.ID.ToString())
                {
                    loaner = reader;

                    labelLoaner.Text = loaner.FirstName + " " + loaner.LastName;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (labelBook.Text != "..." && labelLoaner.Text != "..." && loaner.BookCount < 3 && bookL.IsAvailable == true)
            {
                MessageBox.Show($"Wypożyczenie przebiegło pomyślnie.", "Sukces");

                Loan loan = new Loan(DateTime.Today.Date, loaner, bookL);
                LoanList.AddLoan(loan);

                this.Dispose();
            }
            else
            {
                MessageBox.Show($"Wypożyczenie tej książki przez tego użytkownika jest niemożliwe", "Błąd");
            }
        }

        private Reader loaner;
        private Book bookL;
        private uint _bookID;
    }
}
