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
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            textBox.Text = _editID.ToString();
            textBox.Enabled = false;
            clicked = false;
            textBox2.Text = "Kliknij by odsłonić pole";
            textBox2.Cursor = Cursors.Hand;

            textBox1.Text = userToEdit.Login;
            textBox3.Text = userToEdit.FirstName;
            textBox4.Text = userToEdit.LastName;
            textBox5.Text = userToEdit.Email;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                userToEdit.Login = textBox1.Text;
                userToEdit.FirstName = textBox3.Text;
                userToEdit.LastName = textBox4.Text;
                userToEdit.Email = textBox5.Text;
                if (textBox2.Text != "Kliknij by odsłonić pole")
                    userToEdit.Password = textBox2.Text;

                MessageBox.Show("Dane użytkownika zostały zmienione.","OK");
                this.Close();
            }
            else
            {
                label6.Text = "Pola nie mogą być puste!";
                label6.ForeColor = Color.DarkRed;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                textBox2.Cursor = Cursors.Default;
                textBox2.Text = userToEdit.Password;
            }
            clicked = true;
        }

        public void FindReader(string ID)
        {
            _readerID = Convert.ToUInt32(ID);
            ReaderList.Readers.ForEach(delegate (Reader reader)
            {
                if (reader.ID == _readerID)
                {
                    _editID = _readerID;
                    userToEdit = reader;
                }
            });
        }

        public void FindLibrarian(string ID)
        {
            _librarianID = Convert.ToUInt32(ID);
            LibrarianList.Librarians.ForEach(delegate (Librarian librarian)
            {
                if (librarian.ID == _librarianID)
                {
                    _editID = _librarianID;
                    userToEdit = librarian;
                }
            });
        }

        bool clicked;
        private uint _editID;
        private uint _readerID;
        private uint _librarianID;
        private User userToEdit;

    }
}
