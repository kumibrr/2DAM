using System;
using System.Windows.Forms;

namespace _015_Notepad__
{
    public partial class Form1 : Form
    {

        private FontDialog fDialog = new FontDialog();
        private ColorDialog cDialog = new ColorDialog();

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
            rtxtCanvas.SelectedText = pasteFromClipboard();
        }

        private void tsbtnPaste_Click(object sender, EventArgs e)
        {
            rtxtCanvas.SelectedText = pasteFromClipboard();
        }

        private void tsbtnCopy_Click(object sender, EventArgs e)
        {
            copyToClipboard(rtxtCanvas.SelectedText);
        }

        private void mtsbtnCopy_Click(object sender, EventArgs e)
        {
            copyToClipboard(rtxtCanvas.SelectedText);
        }

        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            copyToClipboard(rtxtCanvas.SelectedText);
            rtxtCanvas.SelectedText = "";
        }

        private void mtsbtnCut_Click(object sender, EventArgs e)
        {
            copyToClipboard(rtxtCanvas.SelectedText);
            rtxtCanvas.SelectedText = "";
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtsbtnUndo_Click(object sender, EventArgs e)
        {
            rtxtCanvas.Undo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtxtCanvas.Font = new System.Drawing.Font("Times", rtxtCanvas.Font.Size);
        }

        private void mtscFontSize_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int size = Int16.Parse(e.ClickedItem.Text);
            rtxtCanvas.Font = new System.Drawing.Font(rtxtCanvas.Font.FontFamily, size);
        }

        private void mtsbtnFontDefault_Click(object sender, EventArgs e)
        {
            rtxtCanvas.Font = new System.Drawing.Font("Times", rtxtCanvas.Font.Size);
        }

        private void mtsbtnFontArial_Click(object sender, EventArgs e)
        {
            rtxtCanvas.Font = new System.Drawing.Font("Arial", rtxtCanvas.Font.Size);
        }

        private void mtsbtnFontCourier_Click(object sender, EventArgs e)
        {
            rtxtCanvas.Font = new System.Drawing.Font("Courier New", rtxtCanvas.Font.Size);
        }

        private void mtsbtnFont_Click(object sender, EventArgs e)
        {
            this.fDialog.Font = rtxtCanvas.Font;
            this.fDialog.ShowDialog();
            rtxtCanvas.Font = this.fDialog.Font;
        }

        private void mtsbtnFontColor_Click(object sender, EventArgs e)
        {
            this.cDialog.Color = rtxtCanvas.ForeColor;
            this.cDialog.ShowDialog();
            rtxtCanvas.ForeColor = this.cDialog.Color;
        }

        private void rtxtCanvas_SelectionChange(object sender, EventArgs e)
        {
            int position = rtxtCanvas.SelectionStart;
            int line = rtxtCanvas.GetLineFromCharIndex(position);
            tslblLineAndPosition.Text = "Línea: " + line + " Posición: " + position.ToString();
        }
    }
}
