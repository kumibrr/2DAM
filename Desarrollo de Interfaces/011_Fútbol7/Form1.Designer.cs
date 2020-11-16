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
            this.lblTeamA.Location = new System.Drawing.Point(368, 37);
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
            this.lblTeamB.Location = new System.Drawing.Point(368, 201);
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
            this.lsAvailablePlayers.Size = new System.Drawing.Size(198, 303);
            this.lsAvailablePlayers.TabIndex = 3;
            // 
            // lsTeamA
            // 
            this.lsTeamA.FormattingEnabled = true;
            this.lsTeamA.Location = new System.Drawing.Point(372, 64);
            this.lsTeamA.Name = "lsTeamA";
            this.lsTeamA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsTeamA.Size = new System.Drawing.Size(174, 134);
            this.lsTeamA.TabIndex = 4;
            // 
            // lsTeamB
            // 
            this.lsTeamB.FormattingEnabled = true;
            this.lsTeamB.Location = new System.Drawing.Point(372, 228);
            this.lsTeamB.Name = "lsTeamB";
            this.lsTeamB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsTeamB.Size = new System.Drawing.Size(174, 134);
            this.lsTeamB.TabIndex = 5;
            // 
            // btnSubstractOneFromA
            // 
            this.btnSubstractOneFromA.Location = new System.Drawing.Point(293, 115);
            this.btnSubstractOneFromA.Name = "btnSubstractOneFromA";
            this.btnSubstractOneFromA.Size = new System.Drawing.Size(35, 23);
            this.btnSubstractOneFromA.TabIndex = 7;
            this.btnSubstractOneFromA.Text = "<";
            this.btnSubstractOneFromA.UseVisualStyleBackColor = true;
            this.btnSubstractOneFromA.Click += new System.EventHandler(this.btnSubstractOneFromA_Click);
            // 
            // btnAddToA
            // 
            this.btnAddToA.Location = new System.Drawing.Point(293, 86);
            this.btnAddToA.Name = "btnAddToA";
            this.btnAddToA.Size = new System.Drawing.Size(35, 23);
            this.btnAddToA.TabIndex = 8;
            this.btnAddToA.Text = ">";
            this.btnAddToA.UseVisualStyleBackColor = true;
            this.btnAddToA.Click += new System.EventHandler(this.btnAddToA_Click);
            // 
            // btnSubstractAllFromA
            // 
            this.btnSubstractAllFromA.Location = new System.Drawing.Point(293, 158);
            this.btnSubstractAllFromA.Name = "btnSubstractAllFromA";
            this.btnSubstractAllFromA.Size = new System.Drawing.Size(35, 23);
            this.btnSubstractAllFromA.TabIndex = 9;
            this.btnSubstractAllFromA.Text = "<<";
            this.btnSubstractAllFromA.UseVisualStyleBackColor = true;
            this.btnSubstractAllFromA.Click += new System.EventHandler(this.btnSubstractAllFromA_Click);
            // 
            // btnAddToB
            // 
            this.btnAddToB.Location = new System.Drawing.Point(293, 244);
            this.btnAddToB.Name = "btnAddToB";
            this.btnAddToB.Size = new System.Drawing.Size(35, 23);
            this.btnAddToB.TabIndex = 10;
            this.btnAddToB.Text = ">";
            this.btnAddToB.UseVisualStyleBackColor = true;
            this.btnAddToB.Click += new System.EventHandler(this.btnAddToB_Click);
            // 
            // btnSubstractOneFromB
            // 
            this.btnSubstractOneFromB.Location = new System.Drawing.Point(293, 273);
            this.btnSubstractOneFromB.Name = "btnSubstractOneFromB";
            this.btnSubstractOneFromB.Size = new System.Drawing.Size(35, 23);
            this.btnSubstractOneFromB.TabIndex = 11;
            this.btnSubstractOneFromB.Text = "<";
            this.btnSubstractOneFromB.UseVisualStyleBackColor = true;
            this.btnSubstractOneFromB.Click += new System.EventHandler(this.btnSubstractOneFromB_Click);
            // 
            // btnSubstractAllFromB
            // 
            this.btnSubstractAllFromB.Location = new System.Drawing.Point(293, 315);
            this.btnSubstractAllFromB.Name = "btnSubstractAllFromB";
            this.btnSubstractAllFromB.Size = new System.Drawing.Size(35, 23);
            this.btnSubstractAllFromB.TabIndex = 12;
            this.btnSubstractAllFromB.Text = "<<";
            this.btnSubstractAllFromB.UseVisualStyleBackColor = true;
            this.btnSubstractAllFromB.Click += new System.EventHandler(this.btnSubstractAllFromB_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(53, 335);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(198, 23);
            this.btnRemovePlayer.TabIndex = 13;
            this.btnRemovePlayer.Text = "Eliminar Jugador";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(53, 357);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(198, 23);
            this.btnAddPlayer.TabIndex = 14;
            this.btnAddPlayer.Text = "Añadir Jugador";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(53, 380);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(198, 20);
            this.txtPlayerName.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(629, 410);
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
    }
}

