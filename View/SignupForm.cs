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
    public partial class SignupForm : Form
    {

        int _user = 0;
        public SignupForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" || textBox2.Text != textBox5.Text)
            {
                label7.Text = "    Hasła nie są takie same!";
                label7.ForeColor = Color.Red;
            }
            if (textBox2.Text == textBox5.Text)
            {
                label7.Text = "OK";
                label7.ForeColor = Color.Green;
            }
            if (textBox2.Text == "")
            {
                label7.Text = "";
            }
        }

        public void user_Type(int userType)
        {
            _user = userType;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox2.Text != textBox5.Text || textBox6.Text == "" )
            {
                MessageBox.Show("Uzupełnij informacje", "Niepowodzenie!");
            }
            else
            {
                if (_user == 1)
                {
                    Librarian newLibrarian = new Librarian(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, textBox6.Text);
                    LibrarianList.AddLibrarian(newLibrarian);

                    string info = $"\nID: {newLibrarian.ID}\nLogin: {newLibrarian.Login}\nImię: {newLibrarian.FirstName}\nNazwisko: {newLibrarian.LastName}\nE-mail: {newLibrarian.Email}";

                    MessageBox.Show("Dodano nowego użytkownika o danych:" + info, "Sukces!");
                }
                else if (_user == 2)
                {

                    Reader newReader = new Reader(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, textBox6.Text);
                    ReaderList.AddReader(newReader);

                    string info = $"\nID: {newReader.ID}\nLogin: {newReader.Login}\nImię: {newReader.FirstName}\nNazwisko: {newReader.LastName}\nE-mail: {newReader.Email}";

                    MessageBox.Show("Dodano nowego użytkownika o danych:" + info, "Sukces!");
                    
                }
                else
                MessageBox.Show("Wystąpił błąd podczas dodawania użytkownika.");

                this.Hide();
            }
        }
        
        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
