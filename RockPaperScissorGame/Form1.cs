using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissorGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clearing the images
            computerpicturebox.Image = null;
            PlayerPictureBox.Image = null;
            panelPlayer.BackColor = Color.LightGray;
            panelComputer.BackColor = Color.LightGray;
            winnerLabel.Text = "................";
            listBox1.Items.Clear();
        }

        private void rockPicturebox_Click(object sender, EventArgs e)
        {
            Random oRandomGenerator = new Random();
            panelPlayer.BackColor = Color.Cornsilk;
            panelComputer.BackColor = Color.Cornsilk;
            int iComputerChoice;

            PlayerPictureBox.Image = rockPicturebox.Image;

            int iRandomNum = oRandomGenerator.Next(100, 4000);
            iComputerChoice = (iRandomNum % 3) + 1;

            switch (iComputerChoice)
            {
                case 1:

                    computerpicturebox.Image = rockPicturebox.Image;
                    winnerLabel.Text = "TIE";
                    listBox1.Items.Add("TIE");
                    break;

                case 2:

                    computerpicturebox.Image = paperPicturebox.Image;
                    winnerLabel.Text = " Computer wins because paper covers rock ";
                    panelComputer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Won by Computer");
                    break;

                case 3:

                    computerpicturebox.Image = scissorsPictureBox.Image;
                    winnerLabel.Text = " YOU win because rock breaks scissors ";
                    panelPlayer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Won by you");
                    break;
            }
        }

        private void paperPicturebox_Click(object sender, EventArgs e)
        {
            Random oRandomGenerator = new Random();
            panelPlayer.BackColor = Color.Cornsilk;
            panelComputer.BackColor = Color.Cornsilk;
            int iComputerChoice;

            PlayerPictureBox.Image = paperPicturebox.Image;

            int iRandomNum = oRandomGenerator.Next(100, 4000);
            iComputerChoice = (iRandomNum % 3) + 1;

            switch (iComputerChoice)
            {

                case 1:

                    computerpicturebox.Image = rockPicturebox.Image;
                    winnerLabel.Text = " YOU win because paper covers rock ";
                    panelPlayer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Won by you");
                    break;

                case 2:

                    computerpicturebox.Image = paperPicturebox.Image;
                    winnerLabel.Text = "TIE";
                    listBox1.Items.Add("TIE");
                    break;

                case 3:

                    computerpicturebox.Image = scissorsPictureBox.Image;
                    winnerLabel.Text = " Computer wins because scissors cuts paper ";
                    panelComputer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Won by Computer");
                    break;

            }

        }

        private void scissorsPictureBox_Click(object sender, EventArgs e)
        {
            Random oRandomGenerator = new Random();
            panelPlayer.BackColor = Color.Cornsilk;
            panelComputer.BackColor = Color.Cornsilk;
            int iComputerChoice;

            PlayerPictureBox.Image = scissorsPictureBox.Image;

            int iRandomNum = oRandomGenerator.Next(100, 4000);
            iComputerChoice = (iRandomNum % 3) + 1;

            switch (iComputerChoice)
            {

                case 1:

                    computerpicturebox.Image = rockPicturebox.Image;
                    winnerLabel.Text = " Computer wins because rock breaks scissors ";
                    panelComputer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Won by Computer");
                    break;

                case 2:

                    computerpicturebox.Image = paperPicturebox.Image;
                    winnerLabel.Text = " YOU win because scissors cuts paper ";
                    panelPlayer.BackColor = Color.Crimson;
                    listBox1.Items.Add("Won by you");
                    break;

                case 3:

                    computerpicturebox.Image = scissorsPictureBox.Image;
                    winnerLabel.Text = "TIE";
                    listBox1.Items.Add("TIE");
                    break;
            }
        }

    }
}
