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
        }

        public override void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reader = LogInView.ActiveReader;
            int count = 1;
            string info = $"Wypożyczyłeś {reader.BookCount} z 3 książek.\n";
            List<string> infos = new List<string> { };
            infos.Add(info);

            if (reader.BookCount == 0)
            {

            }
            else
            {
                foreach (var loan in LoanList.Loans)
                {
                    if (loan.LoanerID == reader.ID)
                    {
                        info = $"{count}. \"{loan.Book.Title}\", {loan.Book.Author} \t do dnia {loan.DateOfReturn}.";
                        infos.Add(info);
                        count++;
                    }
                }
            }
            MessageBox.Show(string.Join("\n", infos.ToArray()), "Stan konta");
        }

        private Reader reader;

        private void MenuReaderForm_Load(object sender, EventArgs e)
        {
            statusToolStripMenuItem.Visible = true;

            tabControl1.TabPages.Remove(tabLibrarians);
            tabControl1.TabPages.Remove(tabUsers);
            tabControl1.TabPages.Remove(tabLoans);
        }
    }
}
