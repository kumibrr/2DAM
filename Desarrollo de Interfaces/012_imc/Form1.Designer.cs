namespace _012_imc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sbWeight = new System.Windows.Forms.VScrollBar();
            this.tbHeight = new System.Windows.Forms.TrackBar();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(940, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Índice de Masa Corporal IMC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura (cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso (Kg)";
            // 
            // sbWeight
            // 
            this.sbWeight.Location = new System.Drawing.Point(327, 214);
            this.sbWeight.Maximum = 200;
            this.sbWeight.Minimum = 1;
            this.sbWeight.Name = "sbWeight";
            this.sbWeight.Size = new System.Drawing.Size(17, 368);
            this.sbWeight.TabIndex = 3;
            this.sbWeight.Value = 200;
            this.sbWeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbWeight_Scroll);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(126, 214);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHeight.Maximum = 300;
            this.tbHeight.Minimum = 5;
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbHeight.Size = new System.Drawing.Size(69, 368);
            this.tbHeight.TabIndex = 4;
            this.tbHeight.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbHeight.Value = 5;
            this.tbHeight.Scroll += new System.EventHandler(this.tbHeight_Scroll);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(126, 591);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(66, 26);
            this.txtHeight.TabIndex = 5;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(302, 591);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(66, 26);
            this.txtWeight.TabIndex = 6;
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(678, 498);
            this.txtIMC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(148, 26);
            this.txtIMC.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_012_imc.Properties.Resources.PesoBajo;
            this.pictureBox1.Location = new System.Drawing.Point(678, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.sbWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.VScrollBar sbWeight;
        private System.Windows.Forms.TrackBar tbHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

