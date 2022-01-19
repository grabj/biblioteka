using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projekt.View
{
    public partial class MenuLibrarianForm : Projekt.Menu
    {
        public MenuLibrarianForm()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabLibrarians);
        }

        public override void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zalogowano jako Bibliotekarz.", "Stan konta");
        }
    }
}
