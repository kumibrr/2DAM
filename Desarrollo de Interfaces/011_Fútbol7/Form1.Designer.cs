namespace _011_Fútbol7
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
            this.lbl_playersAvailable = new System.Windows.Forms.Label();
            this.lblTeamA = new System.Windows.Forms.Label();
            this.lblTeamB = new System.Windows.Forms.Label();
            this.lsAvailablePlayers = new System.Windows.Forms.ListBox();
            this.lsTeamA = new System.Windows.Forms.ListBox();
            this.lsTeamB = new System.Windows.Forms.ListBox();
            this.btnSubstractOneFromA = new System.Windows.Forms.Button();
            this.btnAddToA = new System.Windows.Forms.Button();
            this.btnSubstractAllFromA = new System.Windows.Forms.Button();
            this.btnAddToB = new System.Windows.Forms.Button();
            this.btnSubstractOneFromB = new System.Windows.Forms.Button();
            this.btnSubstractAllFromB = new System.Windows.Forms.Button();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_playersAvailable
            // 
            this.lbl_playersAvailable.AutoSize = true;
            this.lbl_playersAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lbl_playersAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playersAvailable.ForeColor = System.Drawing.Color.White;
            this.lbl_playersAvailable.Location = new System.Drawing.Point(49, 9);
            this.lbl_playersAvailable.Name = "lbl_playersAvailable";
            this.lbl_playersAvailable.Size = new System.Drawing.Size(202, 24);
            this.lbl_playersAvailable.TabIndex = 0;
            this.lbl_playersAvailable.Text = "Jugadores Disponibles";
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamA.ForeColor = System.Drawing.Color.White;
            this.lblTeamA.Location = new System.Drawing.Point(313, 47);
            this.lblTeamA.Name = "lblTeamA";
            this.lblTeamA.Size = new System.Drawing.Size(89, 24);
            this.lblTeamA.TabIndex = 1;
            this.lblTeamA.Text = "Equipo A";
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamB.ForeColor = System.Drawing.Color.White;
            this.lblTeamB.Location = new System.Drawing.Point(313, 211);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(88, 24);
            this.lblTeamB.TabIndex = 2;
            this.lblTeamB.Text = "Equipo B";
            // 
            // lsAvailablePlayers
            // 
            this.lsAvailablePlayers.FormattingEnabled = true;
            this.lsAvailablePlayers.Location = new System.Drawing.Point(53, 33);
            this.lsAvailablePlayers.Name = "lsAvailablePlayers";
            this.lsAvailablePlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsAvailablePlayers.Size = new System.Drawing.Size(198, 329);
            this.lsAvailablePlayers.TabIndex = 3;
            // 
            // lsTeamA
            // 
            this.lsTeamA.FormattingEnabled = true;
            this.lsTeamA.Location = new System.Drawing.Point(317, 74);
            this.lsTeamA.Name = "lsTeamA";
            this.lsTeamA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsTeamA.Size = new System.Drawing.Size(174, 134);
            this.lsTeamA.TabIndex = 4;
            // 
            // lsTeamB
            // 
            this.lsTeamB.FormattingEnabled = true;
            this.lsTeamB.Location = new System.Drawing.Point(317, 238);
            this.lsTeamB.Name = "lsTeamB";
            this.lsTeamB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsTeamB.Size = new System.Drawing.Size(174, 134);
            this.lsTeamB.TabIndex = 5;
            // 
            // btnSubstractOneFromA
            // 
            this.btnSubstractOneFromA.Location = new System.Drawing.Point(266, 125);
            this.btnSubstractOneFromA.Name = "btnSubstractOneFromA";
            this.btnSubstractOneFromA.Size = new System.Drawing.Size(35, 23);
            this.btnSubstractOneFromA.TabIndex = 7;
            this.btnSubstractOneFromA.Text = "<";
            this.btnSubstractOneFromA.UseVisualStyleBackColor = true;
            this.btnSubstractOneFromA.Click += new System.EventHandler(this.btnSubstractOneFromA_Click);
            // 
            // btnAddToA
            // 
            this.btnAddToA.Location = new System.Drawing.Point(266, 96);
            this.btnAddToA.Name = "btnAddToA";
            this.btnAddToA.Size = new System.Drawing.Size(35, 23);
            this.btnAddToA.TabIndex = 8;
            this.btnAddToA.Text = ">";
            this.btnAddToA.UseVisualStyleBackColor = true;
            this.btnAddToA.Click += new System.EventHandler(this.btnAddToA_Click);
            // 
            // btnSubstractAllFromA
            // 
            this.btnSubstractAllFromA.Location = new System.Drawing.Point(266, 168);
            this.btnSubstractAllFromA.Name = "btnSubstractAllFromA";
            this.btnSubstractAllFromA.Size = new System.Drawing.Size(35, 23);
            this.btnSubstractAllFromA.TabIndex = 9;
            this.btnSubstractAllFromA.Text = "<<";
            this.btnSubstractAllFromA.UseVisualStyleBackColor = true;
            this.btnSubstractAllFromA.Click += new System.EventHandler(this.btnSubstractAllFromA_Click);
            // 
            // btnAddToB
            // 
            this.btnAddToB.Location = new System.Drawing.Point(266, 254);
            this.btnAddToB.Name = "btnAddToB";
            this.btnAddToB.Size = new System.Drawing.Size(35, 23);
            this.btnAddToB.TabIndex = 10;
            this.btnAddToB.Text = ">";
            this.btnAddToB.UseVisualStyleBackColor = true;
            this.btnAddToB.Click += new System.EventHandler(this.btnAddToB_Click);
            // 
            // btnSubstractOneFromB
            // 
            this.btnSubstractOneFromB.Location = new System.Drawing.Point(266, 283);
            this.btnSubstractOneFromB.Name = "btnSubstractOneFromB";
            this.btnSubstractOneFromB.Size = new System.Drawing.Size(35, 23);
            this.btnSubstractOneFromB.TabIndex = 11;
            this.btnSubstractOneFromB.Text = "<";
            this.btnSubstractOneFromB.UseVisualStyleBackColor = true;
            this.btnSubstractOneFromB.Click += new System.EventHandler(this.btnSubstractOneFromB_Click);
            // 
            // btnSubstractAllFromB
            // 
            this.btnSubstractAllFromB.Location = new System.Drawing.Point(266, 325);
            this.btnSubstractAllFromB.Name = "btnSubstractAllFromB";
            this.btnSubstractAllFromB.Size = new System.Drawing.Size(35, 23);
            this.btnSubstractAllFromB.TabIndex = 12;
            this.btnSubstractAllFromB.Text = "<<";
            this.btnSubstractAllFromB.UseVisualStyleBackColor = true;
            this.btnSubstractAllFromB.Click += new System.EventHandler(this.btnSubstractAllFromB_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(53, 374);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(198, 23);
            this.btnRemovePlayer.TabIndex = 13;
            this.btnRemovePlayer.Text = "Eliminar Jugador";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(53, 399);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(198, 23);
            this.btnAddPlayer.TabIndex = 14;
            this.btnAddPlayer.Text = "Añadir Jugador";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(53, 425);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(198, 20);
            this.txtPlayerName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Árbitro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Linier 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Linier 2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(425, 404);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(425, 431);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(425, 459);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "trío arbitral: nombres de arbitro y liniers";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(517, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del partido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hora:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(517, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(517, 220);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 538);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnSubstractAllFromB);
            this.Controls.Add(this.btnSubstractOneFromB);
            this.Controls.Add(this.btnAddToB);
            this.Controls.Add(this.btnSubstractAllFromA);
            this.Controls.Add(this.btnAddToA);
            this.Controls.Add(this.btnSubstractOneFromA);
            this.Controls.Add(this.lsTeamB);
            this.Controls.Add(this.lsTeamA);
            this.Controls.Add(this.lsAvailablePlayers);
            this.Controls.Add(this.lblTeamB);
            this.Controls.Add(this.lblTeamA);
            this.Controls.Add(this.lbl_playersAvailable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_playersAvailable;
        private System.Windows.Forms.Label lblTeamA;
        private System.Windows.Forms.Label lblTeamB;
        private System.Windows.Forms.ListBox lsAvailablePlayers;
        private System.Windows.Forms.ListBox lsTeamA;
        private System.Windows.Forms.ListBox lsTeamB;
        private System.Windows.Forms.Button btnSubstractOneFromA;
        private System.Windows.Forms.Button btnAddToA;
        private System.Windows.Forms.Button btnSubstractAllFromA;
        private System.Windows.Forms.Button btnAddToB;
        private System.Windows.Forms.Button btnSubstractOneFromB;
        private System.Windows.Forms.Button btnSubstractAllFromB;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

