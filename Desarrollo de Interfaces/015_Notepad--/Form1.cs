using System;
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

        private void mtsbtnPaste_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = pasteFromClipboard();
        }

        private void tsbtnPaste_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = pasteFromClipboard();
        }

        private void tsbtnCopy_Click(object sender, EventArgs e)
        {
            copyToClipboard(textBox1.SelectedText);
        }

        private void mtsbtnCopy_Click(object sender, EventArgs e)
        {
            copyToClipboard(textBox1.SelectedText);
        }

        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            copyToClipboard(textBox1.SelectedText);
            textBox1.SelectedText = "";
        }

        private void mtsbtnCut_Click(object sender, EventArgs e)
        {
            copyToClipboard(textBox1.SelectedText);
            textBox1.SelectedText = "";
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtsbtnUndo_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Font = new System.Drawing.Font("Times", textBox1.Font.Size);
        }

        private void mtscFontSize_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int size = Int16.Parse(e.ClickedItem.Text);
            textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, size);
        }

        private void mtsbtnFontDefault_Click(object sender, EventArgs e)
        {
            textBox1.Font = new System.Drawing.Font("Times", textBox1.Font.Size);
        }

        private void mtsbtnFontArial_Click(object sender, EventArgs e)
        {
            textBox1.Font = new System.Drawing.Font("Arial", textBox1.Font.Size);
        }

        private void mtsbtnFontCourier_Click(object sender, EventArgs e)
        {
            textBox1.Font = new System.Drawing.Font("Courier New", textBox1.Font.Size);
        }
    }
}
