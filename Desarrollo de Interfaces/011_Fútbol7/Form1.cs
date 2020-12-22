using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _011_Fútbol7
{
    public partial class Form1 : Form
    {
        private OpenFileDialog fbmodal = new OpenFileDialog();

        private String[] players;

        private string emptyList = "No hay ningún jugador.";

        private string[] referee = new string[] { "Pedro pepe", "paco el bola", "felipezeta Girocompleto" };

        // index0 = referee, index1 = assistantreferee1, index2 = assistantreferee2
        private string[] SelectedReferee = new string[3];

        public Form1()
        {
            InitializeComponent();

            cbReferee.Items.AddRange(referee);
            cbAssistantReferee1.Items.AddRange(referee);
            cbAssistantReferee2.Items.AddRange(referee);
        }

        private void openFile()
        {
            StreamReader myFile;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Texto(.txt) | *.txt";
            
        }

        private void IOFromLsToLs(ListBox lsInput, ListBox lsOutput)
        {
            // This method transfers items from one list to another.
            // Removing it from the input list and adding it to the output list.
            for (int i = 0; i < lsInput.SelectedItems.Count;)
            {
                lsOutput.Items.Add(lsInput.SelectedItems[i]);
                lsInput.Items.Remove(lsInput.SelectedItems[i]);
            }
        }

        private void IOAllFromLsToLs(ListBox lsInput, ListBox lsOutput)
        {
            // This method transfers items from one list to another.
            // Removing it from the input list and adding it to the output list.
            for (int i = 0; i < lsInput.Items.Count;)
            {
                lsOutput.Items.Add(lsInput.Items[i]);
                lsInput.Items.Remove(lsInput.Items[i]);
            }
        }

        private bool thereAreSelectedPlayers()
        {
            return lsAvailablePlayers.SelectedItems.Count > 0 || lsTeamA.SelectedItems.Count > 0 || lsTeamB.SelectedItems.Count > 0;
        }

        private void btnAddToA_Click(object sender, EventArgs e)
        {
            IOFromLsToLs(lsAvailablePlayers, lsTeamA);
        }

        private void btnSubstractOneFromA_Click(object sender, EventArgs e)
        {
            IOFromLsToLs(lsTeamA, lsAvailablePlayers);
        }

        private void btnSubstractAllFromA_Click(object sender, EventArgs e)
        {
            IOAllFromLsToLs(lsTeamA, lsAvailablePlayers);
        }

        private void btnAddToB_Click(object sender, EventArgs e)
        {
            IOFromLsToLs(lsAvailablePlayers, lsTeamB);
        }

        private void btnSubstractOneFromB_Click(object sender, EventArgs e)
        {
            IOFromLsToLs(lsTeamB, lsAvailablePlayers);
        }

        private void btnSubstractAllFromB_Click(object sender, EventArgs e)
        {
            IOAllFromLsToLs(lsTeamB, lsAvailablePlayers);
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (thereAreSelectedPlayers())
            {
                if (lsAvailablePlayers.SelectedItems.Count > 0) {
                    for (int i = 0; i < lsAvailablePlayers.SelectedItems.Count;)
                    {
                        lsAvailablePlayers.Items.Remove(lsAvailablePlayers.SelectedItems[i]);
                    }
                }
                if (lsTeamA.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < lsTeamA.SelectedItems.Count; i++)
                    {
                        lsTeamA.Items.Remove(lsTeamA.SelectedItems[i]);
                    }
                }
                if (lsTeamB.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < lsTeamB.SelectedItems.Count;)
                    {
                        lsTeamB.Items.Remove(lsTeamB.SelectedItems[i]);
                    }
                } 
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text != "")
            {
                lsAvailablePlayers.Items.Add(txtPlayerName.Text);
                txtPlayerName.Text = "";
            }
        }

        private void Generic_cbReferee_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            switch(cb.Name)
            {
                case "cbReferee":
                    SelectedReferee[0] = cb.SelectedItem.ToString();
                    break;
                case "cbAssistantReferee1":
                    SelectedReferee[1] = cb.SelectedItem.ToString();
                    break;
                case "cbAssistantReferee2":
                    SelectedReferee[2] = cb.SelectedItem.ToString();
                    break;
            }
            lblReferees.Text = $"Trío de árbitros => Árbitro:{SelectedReferee[0]}, Linier 1: {SelectedReferee[1]}, Linier 2: {SelectedReferee[2]}";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblTime.Text = $"{dateTimePicker1.Value.Hour}:{dateTimePicker1.Value.Minute}";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblDate.Text = $"{e.Start.DayOfWeek}, {e.Start.Day}/{e.Start.Month}/{e.Start.Year}";
        }

        private void tsbtnImport_Click(object sender, EventArgs e)
        {
            fbmodal.Filter = "Ficheros de Texto (*.txt) | *.txt";
            fbmodal.Title = "Cargar jugadores";

            if (fbmodal.ShowDialog() == DialogResult.OK)
            {
                lsAvailablePlayers.Items.AddRange(players = File.ReadAllLines(fbmodal.FileName));
            }
            
        }

        private void tsbtnExportMatchData_Click(object sender, EventArgs e)
        {
            fbmodal.Filter = "Ficheros de Texto (*.txt) | *.txt";
            fbmodal.Title = "Guardar Partido";
            if (fbmodal.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
