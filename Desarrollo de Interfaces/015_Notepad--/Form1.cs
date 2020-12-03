using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_Notepad__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copyToClipboard(string txt)
        {
            Clipboard.SetText(txt);
        }

        private string pasteFromClipboard()
        {
            return Clipboard.GetText();
        }

    }
}
