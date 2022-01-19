using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projekt.View
{
    public partial class MenuReaderForm : Menu
    {
        public MenuReaderForm()
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tabLibrarians);
            tabControl1.TabPages.Remove(tabUsers);
        }

        public override void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int booksLent = LogInView.ActiveReader.BookCount;

            MessageBox.Show($"Zalogowano jako Czytelnik.\nWypożyczyłeś {booksLent} z 3 książek.", "Stan konta");
        }
    }
}
