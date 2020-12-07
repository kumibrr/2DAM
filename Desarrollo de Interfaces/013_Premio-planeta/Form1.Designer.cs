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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.tpWinner = new System.Windows.Forms.TabControl();
            this.tpPrize = new System.Windows.Forms.TabPage();
            this.txtWinnerSynopsis = new System.Windows.Forms.TextBox();
            this.lblWinnerWriter = new System.Windows.Forms.Label();
            this.lblWinnerBookTitle = new System.Windows.Forms.Label();
            this.picWinnerBookCover = new System.Windows.Forms.PictureBox();
            this.tpFinalist = new System.Windows.Forms.TabPage();
            this.txtFinalistSynopsis = new System.Windows.Forms.TextBox();
            this.lblFinalistWriter = new System.Windows.Forms.Label();
            this.lblFinalistBookTitle = new System.Windows.Forms.Label();
            this.picFinalistBookCover = new System.Windows.Forms.PictureBox();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tpWinner.SuspendLayout();
            this.tpPrize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinnerBookCover)).BeginInit();
            this.tpFinalist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFinalistBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::_013_Premio_planeta.Properties.Resources.banner_nadal1;
            this.picLogo.Location = new System.Drawing.Point(729, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(267, 218);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // cmbYear
            // 
            this.cmbYear.Location = new System.Drawing.Point(75, 174);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(180, 28);
            this.cmbYear.Sorted = true;
            this.cmbYear.TabIndex = 1;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // tpWinner
            // 
            this.tpWinner.Controls.Add(this.tpPrize);
            this.tpWinner.Controls.Add(this.tpFinalist);
            this.tpWinner.Location = new System.Drawing.Point(18, 229);
            this.tpWinner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpWinner.Name = "tpWinner";
            this.tpWinner.SelectedIndex = 0;
            this.tpWinner.Size = new System.Drawing.Size(984, 445);
            this.tpWinner.TabIndex = 2;
            // 
            // tpPrize
            // 
            this.tpPrize.Controls.Add(this.txtWinnerSynopsis);
            this.tpPrize.Controls.Add(this.lblWinnerWriter);
            this.tpPrize.Controls.Add(this.lblWinnerBookTitle);
            this.tpPrize.Controls.Add(this.picWinnerBookCover);
            this.tpPrize.Location = new System.Drawing.Point(4, 29);
            this.tpPrize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpPrize.Name = "tpPrize";
            this.tpPrize.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpPrize.Size = new System.Drawing.Size(976, 412);
            this.tpPrize.TabIndex = 0;
            this.tpPrize.Text = "Novela Ganadora";
            this.tpPrize.UseVisualStyleBackColor = true;
            // 
            // txtWinnerSynopsis
            // 
            this.txtWinnerSynopsis.Location = new System.Drawing.Point(417, 105);
            this.txtWinnerSynopsis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWinnerSynopsis.Multiline = true;
            this.txtWinnerSynopsis.Name = "txtWinnerSynopsis";
            this.txtWinnerSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWinnerSynopsis.Size = new System.Drawing.Size(528, 289);
            this.txtWinnerSynopsis.TabIndex = 3;
            // 
            // lblWinnerWriter
            // 
            this.lblWinnerWriter.AutoSize = true;
            this.lblWinnerWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerWriter.Location = new System.Drawing.Point(414, 69);
            this.lblWinnerWriter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinnerWriter.Name = "lblWinnerWriter";
            this.lblWinnerWriter.Size = new System.Drawing.Size(77, 29);
            this.lblWinnerWriter.TabIndex = 2;
            this.lblWinnerWriter.Text = "Writer";
            // 
            // lblWinnerBookTitle
            // 
            this.lblWinnerBookTitle.AutoSize = true;
            this.lblWinnerBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerBookTitle.Location = new System.Drawing.Point(411, 17);
            this.lblWinnerBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinnerBookTitle.Name = "lblWinnerBookTitle";
            this.lblWinnerBookTitle.Size = new System.Drawing.Size(76, 33);
            this.lblWinnerBookTitle.TabIndex = 1;
            this.lblWinnerBookTitle.Text = "Title";
            // 
            // picWinnerBookCover
            // 
            this.picWinnerBookCover.Image = global::_013_Premio_planeta.Properties.Resources.ElAsesinatodeSocrates;
            this.picWinnerBookCover.Location = new System.Drawing.Point(9, 9);
            this.picWinnerBookCover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWinnerBookCover.Name = "picWinnerBookCover";
            this.picWinnerBookCover.Size = new System.Drawing.Size(312, 391);
            this.picWinnerBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWinnerBookCover.TabIndex = 0;
            this.picWinnerBookCover.TabStop = false;
            // 
            // tpFinalist
            // 
            this.tpFinalist.Controls.Add(this.txtFinalistSynopsis);
            this.tpFinalist.Controls.Add(this.lblFinalistWriter);
            this.tpFinalist.Controls.Add(this.lblFinalistBookTitle);
            this.tpFinalist.Controls.Add(this.picFinalistBookCover);
            this.tpFinalist.Location = new System.Drawing.Point(4, 29);
            this.tpFinalist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpFinalist.Name = "tpFinalist";
            this.tpFinalist.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpFinalist.Size = new System.Drawing.Size(976, 412);
            this.tpFinalist.TabIndex = 1;
            this.tpFinalist.Text = "Novela Finalista";
            this.tpFinalist.UseVisualStyleBackColor = true;
            // 
            // txtFinalistSynopsis
            // 
            this.txtFinalistSynopsis.Location = new System.Drawing.Point(417, 105);
            this.txtFinalistSynopsis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFinalistSynopsis.Multiline = true;
            this.txtFinalistSynopsis.Name = "txtFinalistSynopsis";
            this.txtFinalistSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFinalistSynopsis.Size = new System.Drawing.Size(528, 289);
            this.txtFinalistSynopsis.TabIndex = 7;
            // 
            // lblFinalistWriter
            // 
            this.lblFinalistWriter.AutoSize = true;
            this.lblFinalistWriter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalistWriter.Location = new System.Drawing.Point(414, 69);
            this.lblFinalistWriter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalistWriter.Name = "lblFinalistWriter";
            this.lblFinalistWriter.Size = new System.Drawing.Size(77, 29);
            this.lblFinalistWriter.TabIndex = 6;
            this.lblFinalistWriter.Text = "Writer";
            // 
            // lblFinalistBookTitle
            // 
            this.lblFinalistBookTitle.AutoSize = true;
            this.lblFinalistBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalistBookTitle.Location = new System.Drawing.Point(411, 17);
            this.lblFinalistBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalistBookTitle.Name = "lblFinalistBookTitle";
            this.lblFinalistBookTitle.Size = new System.Drawing.Size(76, 33);
            this.lblFinalistBookTitle.TabIndex = 5;
            this.lblFinalistBookTitle.Text = "Title";
            // 
            // picFinalistBookCover
            // 
            this.picFinalistBookCover.Image = global::_013_Premio_planeta.Properties.Resources.ElAsesinatodeSocrates;
            this.picFinalistBookCover.Location = new System.Drawing.Point(9, 9);
            this.picFinalistBookCover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFinalistBookCover.Name = "picFinalistBookCover";
            this.picFinalistBookCover.Size = new System.Drawing.Size(312, 391);
            this.picFinalistBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFinalistBookCover.TabIndex = 4;
            this.picFinalistBookCover.TabStop = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(14, 175);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 29);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Año";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 692);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.tpWinner);
            this.Controls.Add(this.cmbYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.TabControl tpWinner;
        private System.Windows.Forms.TabPage tpPrize;
        private System.Windows.Forms.TabPage tpFinalist;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.PictureBox picWinnerBookCover;
        private System.Windows.Forms.TextBox txtWinnerSynopsis;
        private System.Windows.Forms.Label lblWinnerWriter;
        private System.Windows.Forms.Label lblWinnerBookTitle;
        private System.Windows.Forms.TextBox txtFinalistSynopsis;
        private System.Windows.Forms.Label lblFinalistWriter;
        private System.Windows.Forms.Label lblFinalistBookTitle;
        private System.Windows.Forms.PictureBox picFinalistBookCover;
    }
}

