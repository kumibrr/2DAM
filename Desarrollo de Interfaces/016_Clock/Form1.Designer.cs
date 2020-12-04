
namespace _016_Clock
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_setTimeout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_Clock = new System.Windows.Forms.GroupBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.grp_countdown = new System.Windows.Forms.GroupBox();
            this.lbl_countdown = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.grp_Clock.SuspendLayout();
            this.grp_countdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_setTimeout,
            this.toolStripSeparator1,
            this.btn_exit});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // btn_setTimeout
            // 
            this.btn_setTimeout.Image = global::_016_Clock.Properties.Resources.Timer_16x;
            this.btn_setTimeout.Name = "btn_setTimeout";
            this.btn_setTimeout.Size = new System.Drawing.Size(182, 22);
            this.btn_setTimeout.Text = "Ajustar Cuenta Atrás";
            this.btn_setTimeout.Click += new System.EventHandler(this.btn_setTimeout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::_016_Clock.Properties.Resources.Close_8x_16x;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(182, 22);
            this.btn_exit.Text = "Salir";
            // 
            // grp_Clock
            // 
            this.grp_Clock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Clock.Controls.Add(this.lbl_time);
            this.grp_Clock.Location = new System.Drawing.Point(71, 52);
            this.grp_Clock.Name = "grp_Clock";
            this.grp_Clock.Size = new System.Drawing.Size(308, 81);
            this.grp_Clock.TabIndex = 2;
            this.grp_Clock.TabStop = false;
            this.grp_Clock.Text = "Hora";
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(67, 20);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(174, 46);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "00:00:00";
            // 
            // grp_countdown
            // 
            this.grp_countdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_countdown.Controls.Add(this.lbl_countdown);
            this.grp_countdown.Location = new System.Drawing.Point(71, 166);
            this.grp_countdown.Name = "grp_countdown";
            this.grp_countdown.Size = new System.Drawing.Size(308, 88);
            this.grp_countdown.TabIndex = 3;
            this.grp_countdown.TabStop = false;
            this.grp_countdown.Text = "Cuenta Atrás";
            // 
            // lbl_countdown
            // 
            this.lbl_countdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_countdown.AutoSize = true;
            this.lbl_countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countdown.Location = new System.Drawing.Point(67, 25);
            this.lbl_countdown.Name = "lbl_countdown";
            this.lbl_countdown.Size = new System.Drawing.Size(174, 46);
            this.lbl_countdown.TabIndex = 1;
            this.lbl_countdown.Text = "00:00:00";
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 296);
            this.Controls.Add(this.grp_countdown);
            this.Controls.Add(this.grp_Clock);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp_Clock.ResumeLayout(false);
            this.grp_Clock.PerformLayout();
            this.grp_countdown.ResumeLayout(false);
            this.grp_countdown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_Clock;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.GroupBox grp_countdown;
        private System.Windows.Forms.Label lbl_countdown;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.ToolStripMenuItem btn_setTimeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btn_exit;
    }
}

