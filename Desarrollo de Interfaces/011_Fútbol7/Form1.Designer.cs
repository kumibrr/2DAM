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
            this.cbReferee = new System.Windows.Forms.ComboBox();
            this.cbAssistantReferee1 = new System.Windows.Forms.ComboBox();
            this.cbAssistantReferee2 = new System.Windows.Forms.ComboBox();
            this.lblReferees = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_playersAvailable
            // 
            this.lbl_playersAvailable.AutoSize = true;
            this.lbl_playersAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lbl_playersAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playersAvailable.ForeColor = System.Drawing.Color.White;
            this.lbl_playersAvailable.Location = new System.Drawing.Point(74, 14);
            this.lbl_playersAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_playersAvailable.Name = "lbl_playersAvailable";
            this.lbl_playersAvailable.Size = new System.Drawing.Size(304, 32);
            this.lbl_playersAvailable.TabIndex = 0;
            this.lbl_playersAvailable.Text = "Jugadores Disponibles";
            // 
            // lblTeamA
            // 
            this.lblTeamA.AutoSize = true;
            this.lblTeamA.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamA.ForeColor = System.Drawing.Color.White;
            this.lblTeamA.Location = new System.Drawing.Point(470, 72);
            this.lblTeamA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamA.Name = "lblTeamA";
            this.lblTeamA.Size = new System.Drawing.Size(131, 32);
            this.lblTeamA.TabIndex = 1;
            this.lblTeamA.Text = "Equipo A";
            // 
            // lblTeamB
            // 
            this.lblTeamB.AutoSize = true;
            this.lblTeamB.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamB.ForeColor = System.Drawing.Color.White;
            this.lblTeamB.Location = new System.Drawing.Point(470, 325);
            this.lblTeamB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamB.Name = "lblTeamB";
            this.lblTeamB.Size = new System.Drawing.Size(131, 32);
            this.lblTeamB.TabIndex = 2;
            this.lblTeamB.Text = "Equipo B";
            // 
            // lsAvailablePlayers
            // 
            this.lsAvailablePlayers.FormattingEnabled = true;
            this.lsAvailablePlayers.ItemHeight = 20;
            this.lsAvailablePlayers.Location = new System.Drawing.Point(80, 51);
            this.lsAvailablePlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsAvailablePlayers.Name = "lsAvailablePlayers";
            this.lsAvailablePlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsAvailablePlayers.Size = new System.Drawing.Size(295, 504);
            this.lsAvailablePlayers.TabIndex = 3;
            // 
            // lsTeamA
            // 
            this.lsTeamA.FormattingEnabled = true;
            this.lsTeamA.ItemHeight = 20;
            this.lsTeamA.Location = new System.Drawing.Point(476, 114);
            this.lsTeamA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsTeamA.Name = "lsTeamA";
            this.lsTeamA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsTeamA.Size = new System.Drawing.Size(259, 204);
            this.lsTeamA.TabIndex = 4;
            // 
            // lsTeamB
            // 
            this.lsTeamB.FormattingEnabled = true;
            this.lsTeamB.ItemHeight = 20;
            this.lsTeamB.Location = new System.Drawing.Point(476, 366);
            this.lsTeamB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsTeamB.Name = "lsTeamB";
            this.lsTeamB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsTeamB.Size = new System.Drawing.Size(259, 204);
            this.lsTeamB.TabIndex = 5;
            // 
            // btnSubstractOneFromA
            // 
            this.btnSubstractOneFromA.Location = new System.Drawing.Point(399, 192);
            this.btnSubstractOneFromA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubstractOneFromA.Name = "btnSubstractOneFromA";
            this.btnSubstractOneFromA.Size = new System.Drawing.Size(52, 35);
            this.btnSubstractOneFromA.TabIndex = 7;
            this.btnSubstractOneFromA.Text = "<";
            this.btnSubstractOneFromA.UseVisualStyleBackColor = true;
            this.btnSubstractOneFromA.Click += new System.EventHandler(this.btnSubstractOneFromA_Click);
            // 
            // btnAddToA
            // 
            this.btnAddToA.Location = new System.Drawing.Point(399, 148);
            this.btnAddToA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToA.Name = "btnAddToA";
            this.btnAddToA.Size = new System.Drawing.Size(52, 35);
            this.btnAddToA.TabIndex = 8;
            this.btnAddToA.Text = ">";
            this.btnAddToA.UseVisualStyleBackColor = true;
            this.btnAddToA.Click += new System.EventHandler(this.btnAddToA_Click);
            // 
            // btnSubstractAllFromA
            // 
            this.btnSubstractAllFromA.Location = new System.Drawing.Point(399, 258);
            this.btnSubstractAllFromA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubstractAllFromA.Name = "btnSubstractAllFromA";
            this.btnSubstractAllFromA.Size = new System.Drawing.Size(52, 35);
            this.btnSubstractAllFromA.TabIndex = 9;
            this.btnSubstractAllFromA.Text = "<<";
            this.btnSubstractAllFromA.UseVisualStyleBackColor = true;
            this.btnSubstractAllFromA.Click += new System.EventHandler(this.btnSubstractAllFromA_Click);
            // 
            // btnAddToB
            // 
            this.btnAddToB.Location = new System.Drawing.Point(399, 391);
            this.btnAddToB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToB.Name = "btnAddToB";
            this.btnAddToB.Size = new System.Drawing.Size(52, 35);
            this.btnAddToB.TabIndex = 10;
            this.btnAddToB.Text = ">";
            this.btnAddToB.UseVisualStyleBackColor = true;
            this.btnAddToB.Click += new System.EventHandler(this.btnAddToB_Click);
            // 
            // btnSubstractOneFromB
            // 
            this.btnSubstractOneFromB.Location = new System.Drawing.Point(399, 435);
            this.btnSubstractOneFromB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubstractOneFromB.Name = "btnSubstractOneFromB";
            this.btnSubstractOneFromB.Size = new System.Drawing.Size(52, 35);
            this.btnSubstractOneFromB.TabIndex = 11;
            this.btnSubstractOneFromB.Text = "<";
            this.btnSubstractOneFromB.UseVisualStyleBackColor = true;
            this.btnSubstractOneFromB.Click += new System.EventHandler(this.btnSubstractOneFromB_Click);
            // 
            // btnSubstractAllFromB
            // 
            this.btnSubstractAllFromB.Location = new System.Drawing.Point(399, 500);
            this.btnSubstractAllFromB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubstractAllFromB.Name = "btnSubstractAllFromB";
            this.btnSubstractAllFromB.Size = new System.Drawing.Size(52, 35);
            this.btnSubstractAllFromB.TabIndex = 12;
            this.btnSubstractAllFromB.Text = "<<";
            this.btnSubstractAllFromB.UseVisualStyleBackColor = true;
            this.btnSubstractAllFromB.Click += new System.EventHandler(this.btnSubstractAllFromB_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(80, 575);
            this.btnRemovePlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(297, 35);
            this.btnRemovePlayer.TabIndex = 13;
            this.btnRemovePlayer.Text = "Eliminar Jugador";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(80, 614);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(297, 35);
            this.btnAddPlayer.TabIndex = 14;
            this.btnAddPlayer.Text = "Añadir Jugador";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(80, 654);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(295, 26);
            this.txtPlayerName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 629);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Árbitro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 675);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Linier 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 711);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Linier 2";
            // 
            // cbReferee
            // 
            this.cbReferee.FormattingEnabled = true;
            this.cbReferee.Location = new System.Drawing.Point(638, 622);
            this.cbReferee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbReferee.Name = "cbReferee";
            this.cbReferee.Size = new System.Drawing.Size(180, 28);
            this.cbReferee.TabIndex = 19;
            this.cbReferee.SelectedIndexChanged += new System.EventHandler(this.Generic_cbReferee_SelectedIndexChanged);
            // 
            // cbAssistantReferee1
            // 
            this.cbAssistantReferee1.FormattingEnabled = true;
            this.cbAssistantReferee1.Location = new System.Drawing.Point(638, 663);
            this.cbAssistantReferee1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAssistantReferee1.Name = "cbAssistantReferee1";
            this.cbAssistantReferee1.Size = new System.Drawing.Size(180, 28);
            this.cbAssistantReferee1.TabIndex = 20;
            this.cbAssistantReferee1.SelectedIndexChanged += new System.EventHandler(this.Generic_cbReferee_SelectedIndexChanged);
            // 
            // cbAssistantReferee2
            // 
            this.cbAssistantReferee2.FormattingEnabled = true;
            this.cbAssistantReferee2.Location = new System.Drawing.Point(638, 706);
            this.cbAssistantReferee2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAssistantReferee2.Name = "cbAssistantReferee2";
            this.cbAssistantReferee2.Size = new System.Drawing.Size(180, 28);
            this.cbAssistantReferee2.TabIndex = 21;
            this.cbAssistantReferee2.SelectedIndexChanged += new System.EventHandler(this.Generic_cbReferee_SelectedIndexChanged);
            // 
            // lblReferees
            // 
            this.lblReferees.AutoSize = true;
            this.lblReferees.Location = new System.Drawing.Point(471, 14);
            this.lblReferees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferees.Name = "lblReferees";
            this.lblReferees.Size = new System.Drawing.Size(87, 20);
            this.lblReferees.TabIndex = 22;
            this.lblReferees.Text = "trío arbitral:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(776, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 154);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del partido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(776, 289);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(776, 338);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 25;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(64, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(65, 89);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 20);
            this.lblTime.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 828);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblReferees);
            this.Controls.Add(this.cbAssistantReferee2);
            this.Controls.Add(this.cbAssistantReferee1);
            this.Controls.Add(this.cbReferee);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ComboBox cbReferee;
        private System.Windows.Forms.ComboBox cbAssistantReferee1;
        private System.Windows.Forms.ComboBox cbAssistantReferee2;
        private System.Windows.Forms.Label lblReferees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
    }
}

