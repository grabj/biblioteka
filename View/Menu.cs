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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public virtual void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("rodzic");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInView logInView1 = new LogInView();
            this.Dispose();
            logInView1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public virtual void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n ", "Stan konta");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.SignupForm signupForm = new View.SignupForm();
            signupForm.Show();
        }
    }
}
