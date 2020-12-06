
namespace _015_Notepad__
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mtsbtnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mtscFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnFontCourier = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnFontArial = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnFontDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnFontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTwelve = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFourteen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEighteen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTwentyfour = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThirtysix = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsFile,
            this.mnsEdit,
            this.mnsOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsFile
            // 
            this.mnsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExit});
            this.mnsFile.Name = "mnsFile";
            this.mnsFile.Size = new System.Drawing.Size(88, 29);
            this.mnsFile.Text = "Archivo";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = global::_015_Notepad__.Properties.Resources.Close_red_16x;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.tsbtnExit.Size = new System.Drawing.Size(207, 34);
            this.tsbtnExit.Text = "Salir";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // mnsEdit
            // 
            this.mnsEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsbtnUndo,
            this.toolStripSeparator1,
            this.mtsbtnCut,
            this.mtsbtnCopy,
            this.mtsbtnPaste});
            this.mnsEdit.Name = "mnsEdit";
            this.mnsEdit.Size = new System.Drawing.Size(85, 29);
            this.mnsEdit.Text = "Edición";
            // 
            // mtsbtnUndo
            // 
            this.mtsbtnUndo.Image = global::_015_Notepad__.Properties.Resources.Redo_16x;
            this.mtsbtnUndo.Name = "mtsbtnUndo";
            this.mtsbtnUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.mtsbtnUndo.Size = new System.Drawing.Size(270, 34);
            this.mtsbtnUndo.Text = "Deshacer";
            this.mtsbtnUndo.Click += new System.EventHandler(this.mtsbtnUndo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // mtsbtnCut
            // 
            this.mtsbtnCut.Image = global::_015_Notepad__.Properties.Resources.Cut_16x;
            this.mtsbtnCut.Name = "mtsbtnCut";
            this.mtsbtnCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mtsbtnCut.Size = new System.Drawing.Size(270, 34);
            this.mtsbtnCut.Text = "Cortar";
            this.mtsbtnCut.Click += new System.EventHandler(this.mtsbtnCut_Click);
            // 
            // mtsbtnCopy
            // 
            this.mtsbtnCopy.Image = global::_015_Notepad__.Properties.Resources.Copy_16x;
            this.mtsbtnCopy.Name = "mtsbtnCopy";
            this.mtsbtnCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.mtsbtnCopy.Size = new System.Drawing.Size(270, 34);
            this.mtsbtnCopy.Text = "Copiar";
            this.mtsbtnCopy.Click += new System.EventHandler(this.mtsbtnCopy_Click);
            // 
            // mtsbtnPaste
            // 
            this.mtsbtnPaste.Image = global::_015_Notepad__.Properties.Resources.Paste_16x;
            this.mtsbtnPaste.Name = "mtsbtnPaste";
            this.mtsbtnPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.mtsbtnPaste.Size = new System.Drawing.Size(270, 34);
            this.mtsbtnPaste.Text = "Pegar";
            this.mtsbtnPaste.Click += new System.EventHandler(this.mtsbtnPaste_Click);
            // 
            // mnsOptions
            // 
            this.mnsOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtscFont,
            this.mtsbtnFontSize});
            this.mnsOptions.Name = "mnsOptions";
            this.mnsOptions.Size = new System.Drawing.Size(103, 29);
            this.mnsOptions.Text = "Opciones";
            // 
            // mtscFont
            // 
            this.mtscFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsbtnFontCourier,
            this.mtsbtnFontArial,
            this.mtsbtnFontDefault});
            this.mtscFont.Name = "mtscFont";
            this.mtscFont.Size = new System.Drawing.Size(270, 34);
            this.mtscFont.Text = "Fuente";
            // 
            // mtsbtnFontCourier
            // 
            this.mtsbtnFontCourier.Name = "mtsbtnFontCourier";
            this.mtsbtnFontCourier.Size = new System.Drawing.Size(270, 34);
            this.mtsbtnFontCourier.Text = "Courier New";
            this.mtsbtnFontCourier.Click += new System.EventHandler(this.mtsbtnFontCourier_Click);
            // 
            // mtsbtnFontArial
            // 
            this.mtsbtnFontArial.Name = "mtsbtnFontArial";
            this.mtsbtnFontArial.Size = new System.Drawing.Size(270, 34);
            this.mtsbtnFontArial.Text = "Arial";
            this.mtsbtnFontArial.Click += new System.EventHandler(this.mtsbtnFontArial_Click);
            // 
            // mtsbtnFontDefault
            // 
            this.mtsbtnFontDefault.Name = "mtsbtnFontDefault";
            this.mtsbtnFontDefault.Size = new System.Drawing.Size(270, 34);
            this.mtsbtnFontDefault.Text = "Predeterminada";
            this.mtsbtnFontDefault.Click += new System.EventHandler(this.mtsbtnFontDefault_Click);
            // 
            // mtsbtnFontSize
            // 
            this.mtsbtnFontSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEight,
            this.tsmiTen,
            this.tsmiTwelve,
            this.tsmiFourteen,
            this.tsmiEighteen,
            this.tsmiTwentyfour,
            this.tsmiThirtysix});
            this.mtsbtnFontSize.Name = "mtsbtnFontSize";
            this.mtsbtnFontSize.Size = new System.Drawing.Size(270, 34);
            this.mtsbtnFontSize.Text = "Tamaño";
            this.mtsbtnFontSize.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mtscFontSize_ItemClicked);
            // 
            // tsmiEight
            // 
            this.tsmiEight.Name = "tsmiEight";
            this.tsmiEight.Size = new System.Drawing.Size(134, 34);
            this.tsmiEight.Text = "8";
            // 
            // tsmiTen
            // 
            this.tsmiTen.Name = "tsmiTen";
            this.tsmiTen.Size = new System.Drawing.Size(134, 34);
            this.tsmiTen.Text = "10";
            // 
            // tsmiTwelve
            // 
            this.tsmiTwelve.Name = "tsmiTwelve";
            this.tsmiTwelve.Size = new System.Drawing.Size(134, 34);
            this.tsmiTwelve.Text = "12";
            // 
            // tsmiFourteen
            // 
            this.tsmiFourteen.Name = "tsmiFourteen";
            this.tsmiFourteen.Size = new System.Drawing.Size(134, 34);
            this.tsmiFourteen.Text = "14";
            // 
            // tsmiEighteen
            // 
            this.tsmiEighteen.Name = "tsmiEighteen";
            this.tsmiEighteen.Size = new System.Drawing.Size(134, 34);
            this.tsmiEighteen.Text = "18";
            // 
            // tsmiTwentyfour
            // 
            this.tsmiTwentyfour.Name = "tsmiTwentyfour";
            this.tsmiTwentyfour.Size = new System.Drawing.Size(134, 34);
            this.tsmiTwentyfour.Text = "24";
            // 
            // tsmiThirtysix
            // 
            this.tsmiThirtysix.Name = "tsmiThirtysix";
            this.tsmiThirtysix.Size = new System.Drawing.Size(134, 34);
            this.tsmiThirtysix.Text = "36";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCut,
            this.tsbtnCopy,
            this.tsbtnPaste});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(561, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCut.Image = global::_015_Notepad__.Properties.Resources.Cut_16x;
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Size = new System.Drawing.Size(34, 28);
            this.tsbtnCut.Text = "toolStripButton1";
            this.tsbtnCut.Click += new System.EventHandler(this.tsbtnCut_Click);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCopy.Image = global::_015_Notepad__.Properties.Resources.Copy_16x;
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Size = new System.Drawing.Size(34, 28);
            this.tsbtnCopy.Text = "toolStripButton2";
            this.tsbtnCopy.Click += new System.EventHandler(this.tsbtnCopy_Click);
            // 
            // tsbtnPaste
            // 
            this.tsbtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPaste.Image = global::_015_Notepad__.Properties.Resources.Paste_16x;
            this.tsbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaste.Name = "tsbtnPaste";
            this.tsbtnPaste.Size = new System.Drawing.Size(34, 28);
            this.tsbtnPaste.Text = "toolStripButton3";
            this.tsbtnPaste.Click += new System.EventHandler(this.tsbtnPaste_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(18, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 256);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 357);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(574, 385);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsFile;
        private System.Windows.Forms.ToolStripMenuItem mnsEdit;
        private System.Windows.Forms.ToolStripMenuItem mtsbtnUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mtsbtnCut;
        private System.Windows.Forms.ToolStripMenuItem mtsbtnCopy;
        private System.Windows.Forms.ToolStripMenuItem mtsbtnPaste;
        private System.Windows.Forms.ToolStripMenuItem mnsOptions;
        private System.Windows.Forms.ToolStripMenuItem mtscFont;
        private System.Windows.Forms.ToolStripMenuItem mtsbtnFontCourier;
        private System.Windows.Forms.ToolStripMenuItem mtsbtnFontArial;
        private System.Windows.Forms.ToolStripMenuItem mtsbtnFontDefault;
        private System.Windows.Forms.ToolStripMenuItem mtsbtnFontSize;
        private System.Windows.Forms.ToolStripMenuItem tsbtnExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnCopy;
        private System.Windows.Forms.ToolStripButton tsbtnPaste;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEight;
        private System.Windows.Forms.ToolStripMenuItem tsmiTen;
        private System.Windows.Forms.ToolStripMenuItem tsmiTwelve;
        private System.Windows.Forms.ToolStripMenuItem tsmiFourteen;
        private System.Windows.Forms.ToolStripMenuItem tsmiEighteen;
        private System.Windows.Forms.ToolStripMenuItem tsmiTwentyfour;
        private System.Windows.Forms.ToolStripMenuItem tsmiThirtysix;
    }
}

