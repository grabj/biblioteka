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
    public partial class ConfirmDeleteReader : Form
    {
        private uint _DeleteID;
        private uint _readerID;

        public ConfirmDeleteReader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReaderList.RemoveReader(_DeleteID);
            Globals.form.Refresh_Menu();
            this.Hide();
        }

        public void FindReader(string readerID)
        {
            _readerID = Convert.ToUInt32(readerID);
            ReaderList.Readers.ForEach(delegate (Reader Reader)
            {
                if (Reader.ID == _readerID)
                {
                    _DeleteID = _readerID;
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
