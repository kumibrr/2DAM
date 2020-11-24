namespace _013_Premio_planeta
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
            this.picFinalistCover = new System.Windows.Forms.PictureBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.tpWinner = new System.Windows.Forms.TabControl();
            this.tpPrize = new System.Windows.Forms.TabPage();
            this.txtWinnerSynopsis = new System.Windows.Forms.TextBox();
            this.lblWinnerWriter = new System.Windows.Forms.Label();
            this.lblWinnerBookTitle = new System.Windows.Forms.Label();
            this.picWinnerBookCover = new System.Windows.Forms.PictureBox();
            this.tpFinalist = new System.Windows.Forms.TabPage();
            this.lblFinalistSynopsis = new System.Windows.Forms.TextBox();
            this.lblFinalistWriter = new System.Windows.Forms.Label();
            this.lblFinalistBookTitle = new System.Windows.Forms.Label();
            this.picFinalistBookCover = new System.Windows.Forms.PictureBox();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalistCover)).BeginInit();
            this.tpWinner.SuspendLayout();
            this.tpPrize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinnerBookCover)).BeginInit();
            this.tpFinalist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalistBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // picFinalistCover
            // 
            this.picFinalistCover.Image = global::_013_Premio_planeta.Properties.Resources.banner_nadal1;
            this.picFinalistCover.Location = new System.Drawing.Point(486, 12);
            this.picFinalistCover.Name = "picFinalistCover";
            this.picFinalistCover.Size = new System.Drawing.Size(178, 142);
            this.picFinalistCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFinalistCover.TabIndex = 0;
            this.picFinalistCover.TabStop = false;
            // 
            // cmbYear
            // 
            this.cmbYear.Location = new System.Drawing.Point(50, 113);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.Sorted = true;
            this.cmbYear.TabIndex = 1;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // tpWinner
            // 
            this.tpWinner.Controls.Add(this.tpPrize);
            this.tpWinner.Controls.Add(this.tpFinalist);
            this.tpWinner.Location = new System.Drawing.Point(12, 149);
            this.tpWinner.Name = "tpWinner";
            this.tpWinner.SelectedIndex = 0;
            this.tpWinner.Size = new System.Drawing.Size(656, 289);
            this.tpWinner.TabIndex = 2;
            // 
            // tpPrize
            // 
            this.tpPrize.Controls.Add(this.txtWinnerSynopsis);
            this.tpPrize.Controls.Add(this.lblWinnerWriter);
            this.tpPrize.Controls.Add(this.lblWinnerBookTitle);
            this.tpPrize.Controls.Add(this.picWinnerBookCover);
            this.tpPrize.Location = new System.Drawing.Point(4, 22);
            this.tpPrize.Name = "tpPrize";
            this.tpPrize.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrize.Size = new System.Drawing.Size(648, 263);
            this.tpPrize.TabIndex = 0;
            this.tpPrize.Text = "Novela Ganadora";
            this.tpPrize.UseVisualStyleBackColor = true;
            // 
            // txtWinnerSynopsis
            // 
            this.txtWinnerSynopsis.Location = new System.Drawing.Point(278, 68);
            this.txtWinnerSynopsis.Multiline = true;
            this.txtWinnerSynopsis.Name = "txtWinnerSynopsis";
            this.txtWinnerSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWinnerSynopsis.Size = new System.Drawing.Size(353, 189);
            this.txtWinnerSynopsis.TabIndex = 3;
            // 
            // lblWinnerWriter
            // 
            this.lblWinnerWriter.AutoSize = true;
            this.lblWinnerWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerWriter.Location = new System.Drawing.Point(276, 45);
            this.lblWinnerWriter.Name = "lblWinnerWriter";
            this.lblWinnerWriter.Size = new System.Drawing.Size(51, 20);
            this.lblWinnerWriter.TabIndex = 2;
            this.lblWinnerWriter.Text = "Writer";
            // 
            // lblWinnerBookTitle
            // 
            this.lblWinnerBookTitle.AutoSize = true;
            this.lblWinnerBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerBookTitle.Location = new System.Drawing.Point(274, 11);
            this.lblWinnerBookTitle.Name = "lblWinnerBookTitle";
            this.lblWinnerBookTitle.Size = new System.Drawing.Size(50, 24);
            this.lblWinnerBookTitle.TabIndex = 1;
            this.lblWinnerBookTitle.Text = "Title";
            // 
            // picWinnerBookCover
            // 
            this.picWinnerBookCover.Image = global::_013_Premio_planeta.Properties.Resources.ElAsesinatodeSocrates;
            this.picWinnerBookCover.Location = new System.Drawing.Point(6, 6);
            this.picWinnerBookCover.Name = "picWinnerBookCover";
            this.picWinnerBookCover.Size = new System.Drawing.Size(208, 254);
            this.picWinnerBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWinnerBookCover.TabIndex = 0;
            this.picWinnerBookCover.TabStop = false;
            // 
            // tpFinalist
            // 
            this.tpFinalist.Controls.Add(this.lblFinalistSynopsis);
            this.tpFinalist.Controls.Add(this.lblFinalistWriter);
            this.tpFinalist.Controls.Add(this.lblFinalistBookTitle);
            this.tpFinalist.Controls.Add(this.picFinalistBookCover);
            this.tpFinalist.Location = new System.Drawing.Point(4, 22);
            this.tpFinalist.Name = "tpFinalist";
            this.tpFinalist.Padding = new System.Windows.Forms.Padding(3);
            this.tpFinalist.Size = new System.Drawing.Size(648, 263);
            this.tpFinalist.TabIndex = 1;
            this.tpFinalist.Text = "Novela Finalista";
            this.tpFinalist.UseVisualStyleBackColor = true;
            // 
            // lblFinalistSynopsis
            // 
            this.lblFinalistSynopsis.Location = new System.Drawing.Point(278, 68);
            this.lblFinalistSynopsis.Multiline = true;
            this.lblFinalistSynopsis.Name = "lblFinalistSynopsis";
            this.lblFinalistSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblFinalistSynopsis.Size = new System.Drawing.Size(353, 189);
            this.lblFinalistSynopsis.TabIndex = 7;
            // 
            // lblFinalistWriter
            // 
            this.lblFinalistWriter.AutoSize = true;
            this.lblFinalistWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalistWriter.Location = new System.Drawing.Point(276, 45);
            this.lblFinalistWriter.Name = "lblFinalistWriter";
            this.lblFinalistWriter.Size = new System.Drawing.Size(51, 20);
            this.lblFinalistWriter.TabIndex = 6;
            this.lblFinalistWriter.Text = "Writer";
            // 
            // lblFinalistBookTitle
            // 
            this.lblFinalistBookTitle.AutoSize = true;
            this.lblFinalistBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalistBookTitle.Location = new System.Drawing.Point(274, 11);
            this.lblFinalistBookTitle.Name = "lblFinalistBookTitle";
            this.lblFinalistBookTitle.Size = new System.Drawing.Size(50, 24);
            this.lblFinalistBookTitle.TabIndex = 5;
            this.lblFinalistBookTitle.Text = "Title";
            // 
            // picFinalistBookCover
            // 
            this.picFinalistBookCover.Image = global::_013_Premio_planeta.Properties.Resources.ElAsesinatodeSocrates;
            this.picFinalistBookCover.Location = new System.Drawing.Point(6, 6);
            this.picFinalistBookCover.Name = "picFinalistBookCover";
            this.picFinalistBookCover.Size = new System.Drawing.Size(208, 254);
            this.picFinalistBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFinalistBookCover.TabIndex = 4;
            this.picFinalistBookCover.TabStop = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(9, 114);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 20);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Año";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.picFinalistCover);
            this.Controls.Add(this.tpWinner);
            this.Controls.Add(this.cmbYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picFinalistCover)).EndInit();
            this.tpWinner.ResumeLayout(false);
            this.tpPrize.ResumeLayout(false);
            this.tpPrize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinnerBookCover)).EndInit();
            this.tpFinalist.ResumeLayout(false);
            this.tpFinalist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalistBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFinalistCover;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.TabControl tpWinner;
        private System.Windows.Forms.TabPage tpPrize;
        private System.Windows.Forms.TabPage tpFinalist;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.PictureBox picWinnerBookCover;
        private System.Windows.Forms.TextBox txtWinnerSynopsis;
        private System.Windows.Forms.Label lblWinnerWriter;
        private System.Windows.Forms.Label lblWinnerBookTitle;
        private System.Windows.Forms.TextBox lblFinalistSynopsis;
        private System.Windows.Forms.Label lblFinalistWriter;
        private System.Windows.Forms.Label lblFinalistBookTitle;
        private System.Windows.Forms.PictureBox picFinalistBookCover;
    }
}

