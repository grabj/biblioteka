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
    public partial class ConfirmDeleteLibrarian : Form
    {
        private uint _DeleteID;
        private uint _librarianID;

        public ConfirmDeleteLibrarian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LibrarianList.RemoveLibrarian(_DeleteID);
            //Globals.form.Refresh_Menu();
            this.Hide();
        }

        public void FindLibrarian(string librarianID)
        {
            _librarianID = Convert.ToUInt32(librarianID);
            LibrarianList.Librarians.ForEach(delegate (Librarian Librarian)
            {
                if (Librarian.ID == _librarianID)
                {
                    _DeleteID = _librarianID;
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

