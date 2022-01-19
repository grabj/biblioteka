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

            textBox1.Enabled = true;

            if (LogInView.ActiveReader != null)
            {
                loaner = LogInView.ActiveReader;

                textBox1.Text = loaner.ID.ToString();
                textBox1.Enabled = false;

                labelLoaner.Text = loaner.FirstName + " " + loaner.LastName;
            }

            labelDate1.Text = DateTime.Today.ToString();
            labelDate2.Text = DateTime.Today.AddDays(30).ToString();
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
            foreach (var book in BookList.Books)
            {
                if (textBox2.Text == book.BookID.ToString())
                {
                    bookL = book;

                    labelBook.Text = "\"" + book.Title + "\"";
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (labelBook.Text != "..." && labelLoaner.Text != "..." && loaner.BookCount < 3)
            {
                MessageBox.Show($"Wypożyczenie przebiegło pomyślnie.", "Sukces");

                Loan loan = new Loan(DateTime.Today, loaner, bookL);
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
    }
}
