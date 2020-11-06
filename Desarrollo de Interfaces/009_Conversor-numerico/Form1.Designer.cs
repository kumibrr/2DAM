namespace _009_Conversor_numerico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblBinary = new System.Windows.Forms.Label();
            this.lblOctal = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.txtOctal = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgLebron = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLebron)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AllowDrop = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(510, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Conversor Numérico";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDecimal
            // 
            this.lblDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDecimal.Location = new System.Drawing.Point(42, 98);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(140, 23);
            this.lblDecimal.TabIndex = 1;
            this.lblDecimal.Text = "Número Decimal";
            this.lblDecimal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBinary
            // 
            this.lblBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBinary.Location = new System.Drawing.Point(42, 134);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(140, 23);
            this.lblBinary.TabIndex = 2;
            this.lblBinary.Text = "Binario";
            this.lblBinary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOctal
            // 
            this.lblOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOctal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOctal.Location = new System.Drawing.Point(42, 169);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(140, 23);
            this.lblOctal.TabIndex = 3;
            this.lblOctal.Text = "Octal";
            this.lblOctal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHex
            // 
            this.lblHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHex.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHex.Location = new System.Drawing.Point(42, 204);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(140, 23);
            this.lblHex.TabIndex = 4;
            this.lblHex.Text = "Hexadecimal";
            this.lblHex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(207, 98);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 5;
            // 
            // txtBinary
            // 
            this.txtBinary.Enabled = false;
            this.txtBinary.Location = new System.Drawing.Point(207, 134);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(100, 20);
            this.txtBinary.TabIndex = 6;
            // 
            // txtOctal
            // 
            this.txtOctal.Enabled = false;
            this.txtOctal.Location = new System.Drawing.Point(207, 169);
            this.txtOctal.Name = "txtOctal";
            this.txtOctal.Size = new System.Drawing.Size(100, 20);
            this.txtOctal.TabIndex = 7;
            // 
            // txtHex
            // 
            this.txtHex.Enabled = false;
            this.txtHex.Location = new System.Drawing.Point(207, 204);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(100, 20);
            this.txtHex.TabIndex = 8;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Black;
            this.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConvert.Location = new System.Drawing.Point(46, 267);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(261, 23);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "CONVERTIR";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(46, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(261, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgLebron
            // 
            this.imgLebron.Image = ((System.Drawing.Image)(resources.GetObject("imgLebron.Image")));
            this.imgLebron.Location = new System.Drawing.Point(349, 98);
            this.imgLebron.Name = "imgLebron";
            this.imgLebron.Size = new System.Drawing.Size(149, 221);
            this.imgLebron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLebron.TabIndex = 11;
            this.imgLebron.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 347);
            this.Controls.Add(this.imgLebron);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtOctal);
            this.Controls.Add(this.txtBinary);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblOctal);
            this.Controls.Add(this.lblBinary);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Conversor Numérico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLebron)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.Label lblOctal;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.TextBox txtOctal;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox imgLebron;
    }
}

