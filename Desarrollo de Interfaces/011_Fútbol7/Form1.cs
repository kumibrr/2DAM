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
            for (int i = 0; i < lsInput.SelectedItems.Count; i++)
            {
                lsOutput.Items.Add(lsInput.SelectedItems[i].ToString());
            }
        }

        private void btnAddToA_Click(object sender, EventArgs e)
        {
            IOFromLsToLs(lsAvailablePlayers, lsTeamA);
        }
    }
}
