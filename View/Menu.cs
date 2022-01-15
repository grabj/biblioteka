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
    }
}
