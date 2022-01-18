using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projekt
{
    public partial class MenuLibrarianView : Menu
    {
        public MenuLibrarianView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabLibrarians);
        }
    }
}
