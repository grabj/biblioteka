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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();

            if (LogInView.ActiveReader != null)
            {
                loanerR = LogInView.ActiveReader;

                textBox1.Text = loanerR.ID.ToString();
                textBox1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 1;
            bool readerFound = false;

            foreach (var reader in ReaderList.Readers)
            {
                if (textBox1.Text == reader.ID.ToString())
                {
                    loanerR = reader;
                    readerFound = true;
                }
            }
            if (readerFound)
            {
                foreach (var loan in LoanList.Loans)
                {
                    if (loan.LoanerID == loanerR.ID)
                    {
                        string info = $"{count}. \"{loan.Book.Title}\", {loan.Book.Author} \t do dnia {loan.DateOfReturn.ToShortDateString()}";
                        listBox1.Items.Add(info);
                        count++;
                        loanR = loan;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie znaleziono uzytkownika o podanym ID", "Błąd");
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                loanR.ReturnBook();

                LoanList.RemoveLoan(loanR.ID);

                MessageBox.Show($"Książka została zwrócona.", "Sukces");
                Globals.form.Refresh_Menu();
                this.Dispose();
            }
        }

        private Reader loanerR;
        private Loan loanR;
    }
}
