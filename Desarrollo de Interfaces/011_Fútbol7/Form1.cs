using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _011_Fútbol7
{
    public partial class Form1 : Form
    {
        private string emptyList = "No hay ningún jugador.";

        private string[] players = new string[] {
        "Casillas","Bufon","Pelé","Maradona","Messi","Cristiano Ronaldo","Alfredo di Stéfano","Beckenbauer",
        "Ronaldo Nazario","Juanito","Zinedine Zidane","Johan Cruyff","Dani Güiza","Ronaldinho",
        "Gerd Muller","Marco van Basten","Xavi Hernández","Raul Gonzalez" };

        public Form1()
        {
            InitializeComponent();
            lsAvailablePlayers.Items.AddRange(players);
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
    }
}
