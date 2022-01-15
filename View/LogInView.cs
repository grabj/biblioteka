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
            //if (textBox1 == "admin")
            //Form1 menuAdmin = new Form1();
            Menu menuUser = new Menu();
            this.Hide();
            menuUser.Show();
        }
    }
}
