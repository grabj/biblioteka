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

        public override void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brak danych. Zarejestruj się!", "Stan konta");
        }
    }
}
