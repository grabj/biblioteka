using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class MenuReaderView : Menu
    {
        public MenuReaderView()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabUsers);
            tabControl1.TabPages.Remove(tabLibrarians);
        }
    }
}
