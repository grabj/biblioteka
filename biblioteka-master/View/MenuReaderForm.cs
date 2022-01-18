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
    }
}
