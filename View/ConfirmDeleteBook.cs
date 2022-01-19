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
    public partial class ConfirmDeleteBook : Form
    {
        private uint _DeleteID;
        private uint _BookID;

        public ConfirmDeleteBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookList.RemoveBook(_DeleteID);
            Globals.form.Refresh_Menu();
            this.Hide();
        }

        public void FindBook(string librarianID)
        {
            _BookID = Convert.ToUInt32(librarianID);
            BookList.Books.ForEach(delegate (Book Books)
            {
                if (Books.BookID == _BookID)
                {
                    _DeleteID = _BookID;
                }
            });

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void ConfirmForm_Load(object sender, EventArgs e)
        {

        }
    }
}

