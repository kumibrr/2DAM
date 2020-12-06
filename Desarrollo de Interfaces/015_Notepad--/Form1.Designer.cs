
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
            this.mnsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsbtnFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblLineAndPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtxtCanvas = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsFile,
            this.mnsEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsFile
            // 
            this.mnsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsbtnExit});
            this.mnsFile.Name = "mnsFile";
            this.mnsFile.Size = new System.Drawing.Size(88, 32);
            this.mnsFile.Text = "Archivo";
            // 
            // mnsEdit
            // 
            this.mnsEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsbtnUndo,
            this.toolStripSeparator1,
            this.mtsbtnCut,
            this.mtsbtnCopy,
            this.mtsbtnPaste,
            this.mtsbtnFont,
            this.mtsbtnFontColor});
            this.mnsEdit.Name = "mnsEdit";
            this.mnsEdit.Size = new System.Drawing.Size(85, 29);
            this.mnsEdit.Text = "Edición";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
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
            this.toolStrip1.Size = new System.Drawing.Size(919, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCut.Image = global::_015_Notepad__.Properties.Resources.Cut_16x;
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Size = new System.Drawing.Size(34, 33);
            this.tsbtnCut.Text = "toolStripButton1";
            this.tsbtnCut.Click += new System.EventHandler(this.tsbtnCut_Click);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCopy.Image = global::_015_Notepad__.Properties.Resources.Copy_16x;
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Size = new System.Drawing.Size(34, 33);
            this.tsbtnCopy.Text = "toolStripButton2";
            this.tsbtnCopy.Click += new System.EventHandler(this.tsbtnCopy_Click);
            // 
            // tsbtnPaste
            // 
            this.tsbtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPaste.Image = global::_015_Notepad__.Properties.Resources.Paste_16x;
            this.tsbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaste.Name = "tsbtnPaste";
            this.tsbtnPaste.Size = new System.Drawing.Size(34, 33);
            this.tsbtnPaste.Text = "toolStripButton3";
            this.tsbtnPaste.Click += new System.EventHandler(this.tsbtnPaste_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::_015_Notepad__.Properties.Resources.NewFile_16x;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::_015_Notepad__.Properties.Resources.OpenFile_16x;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::_015_Notepad__.Properties.Resources.Save_16x;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = global::_015_Notepad__.Properties.Resources.Close_red_16x;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.tsbtnExit.Size = new System.Drawing.Size(270, 34);
            this.tsbtnExit.Text = "Salir";
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
            // mtsbtnFont
            // 
            this.mtsbtnFont.Image = global::_015_Notepad__.Properties.Resources.Font_16x;
            this.mtsbtnFont.Name = "mtsbtnFont";
            this.mtsbtnFont.Size = new System.Drawing.Size(270, 34);
            this.mtsbtnFont.Text = "Fuente";
            this.mtsbtnFont.Click += new System.EventHandler(this.mtsbtnFont_Click);
            // 
            // mtsbtnFontColor
            // 
            this.mtsbtnFontColor.Image = global::_015_Notepad__.Properties.Resources.ColorPalette_16x;
            this.mtsbtnFontColor.Name = "mtsbtnFontColor";
            this.mtsbtnFontColor.Size = new System.Drawing.Size(270, 34);
            this.mtsbtnFontColor.Text = "Color";
            this.mtsbtnFontColor.Click += new System.EventHandler(this.mtsbtnFontColor_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblLineAndPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 783);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblLineAndPosition
            // 
            this.tslblLineAndPosition.Name = "tslblLineAndPosition";
            this.tslblLineAndPosition.Size = new System.Drawing.Size(150, 25);
            this.tslblLineAndPosition.Text = "Línea:1 Posición:3";
            // 
            // rtxtCanvas
            // 
            this.rtxtCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtCanvas.Location = new System.Drawing.Point(12, 77);
            this.rtxtCanvas.Name = "rtxtCanvas";
            this.rtxtCanvas.Size = new System.Drawing.Size(895, 689);
            this.rtxtCanvas.TabIndex = 4;
            this.rtxtCanvas.Text = "";
            this.rtxtCanvas.SelectionChanged += new System.EventHandler(this.rtxtCanvas_SelectionChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 815);
            this.Controls.Add(this.rtxtCanvas);
            this.Controls.Add(this.statusStrip1);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnCopy;
        private System.Windows.Forms.ToolStripButton tsbtnPaste;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsbtnExit;
        private System.Windows.Forms.ToolStripMenuItem mtsbtnFont;
        private System.Windows.Forms.ToolStripMenuItem mtsbtnFontColor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblLineAndPosition;
        private System.Windows.Forms.RichTextBox rtxtCanvas;
    }
}

