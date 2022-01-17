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
    public partial class LogInView : Form
    {
        public LogInView()
        {
            InitializeComponent();
            Reader user1 = new Reader("Ewa", "Nowak", "EA@wp.pl", "Nowak", "en");
            ReaderList.AddReader(user1);
            //Librarian user2 = new Librarian("Adam", "Filipiak", "FilA@wp.pl", "Filipiak", "af");
            //MessageBox.Show("");
            //MessageBox.Show(user1.Password + " " + user1.Login);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuGuestView menuGuest = new MenuGuestView();
            this.Hide();
            menuGuest.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = Admin.GetInstance;
            if (textBox1.Text == admin.Login && textBox2.Text == admin.Password)
            {
                Menu menuUser = new Menu();
                this.Hide();
                menuUser.Show();
            }
            //if (textBox1.Text == )
            
            Menu menuUser2 = new Menu();
            this.Hide();
            menuUser2.Show();
        }
    }
}
