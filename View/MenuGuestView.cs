using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projekt
{
    public partial class MenuGuestView : Menu
    {
        public MenuGuestView()
        {
            InitializeComponent();
        }

        private void MenuGuestView_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabLibrarians);
            tabControl1.TabPages.Remove(tabUsers);
            tabControl1.TabPages.Remove(tabLoans);
            signupToolStripMenuItem.Text = "Zarejestruj się";
        }
    }
}
