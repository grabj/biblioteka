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

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox2.Text != textBox5.Text || textBox6.Text == "" )
            {
                MessageBox.Show("Uzupełnij informacje!", "Niepowodzenie");
            }
            else
            {
                Reader newUser = new Reader(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, textBox6.Text);
                ReaderList.AddReader(newUser);

                string info = $"\nID: {newUser.ID}\nLogin: {newUser.Login}\nImię: {newUser.FirstName}\nNazwisko: {newUser.LastName}\nE-mail: {newUser.Email}";

                MessageBox.Show("Dodano nowego użytkownika o danych:" + info, "Sukces!");
                this.Hide();
            }
        }
    }
}
