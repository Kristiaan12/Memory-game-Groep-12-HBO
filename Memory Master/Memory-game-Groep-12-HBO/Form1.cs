using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Memory_game_Groep_12_HBO
{
    public partial class Form1 : Form
    {
        int currPlayer = 1;
        int streakP1 = 0;
        int streakP2 = 0;
        Boolean beginTurnP2 = true;
        Boolean p1Done = false;
        Boolean p2Done = false;
        int[] Highscore = new int[10];
        string[] Highscorenaam = new string[10];
        int intScore1 = 0;
        int intScore2 = 0;
        bool allowClick = false;
        Timer clickTimer = new Timer();
        int time = 60;
        int time2 = 60;
        Timer timer = new Timer { Interval = 1000 };
        Timer timer2 = new Timer { Interval = 1000 };

        // Use this Random object to choose random icons for the squares
        Random random = new Random();

        // Each of these letters is an interesting icon
        // in the Webdings font,
        // and each icon appears twice in this list
        List<string> icons = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
    };

        /// <summary>
        /// Assign each icon from the list of icons to a random square
        /// </summary>
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        // firstClicked points to the first Label control 
        // that the player clicks, but it will be null 
        // if the player hasn't clicked a label yet
        Label firstClicked = null;

        // secondClicked points to the second Label control 
        // that the player clicks
        Label secondClicked = null;

        private void startGameTimer(Boolean run)
        {

            if (run)
            {
                label3.Visible = true;
                timer.Start();

                timer.Tick += delegate
                {
                    time--;
                    if (time < 0)
                    {
                        timer.Stop();
                        MessageBox.Show("Je tijd is op!");
                        p1Done = true;
                        allowClick = false;
                        //Only reset when the game is over?
                        //ResetImages();
                    }

                    var ssTime = TimeSpan.FromSeconds(time);

                    label1.Text = "P1: 00:" + time.ToString();
                };
            }
            if (!run)
            {
                timer.Stop();
            }
            
        }        

        private void startGameTimerP2(Boolean run)
        {   
          
            if (run)
            {
                label3.Visible = true;
                timer2.Start();
                timer2.Tick += delegate
                {
                    time2--;
                    if (time2 < 0)
                    {
                        timer2.Stop();
                        MessageBox.Show("Je tijd is op!");
                        p2Done = true;
                        allowClick = false;
                        //Only reset when the game is over?
                        //ResetImages();
                    }

                    var ssTime2 = TimeSpan.FromSeconds(time);

                    label3.Text = "P2: 00:" + time2.ToString();
                };
            }
            if (!run)
            {
                timer2.Stop();
            }
           
        }


        /// <summary>
        /// Every label's Click event is handled by this event handler
        /// </summary>
        /// <param name="sender">The label that was clicked</param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            // The timer is only on after two non-matching 
            // icons have been shown to the player, 
            // so ignore any clicks if the timer is running
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // If firstClicked is null, this is the first icon
                // in the pair that the player clicked, 
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                // If the player gets this far, the timer isn't
                // running and firstClicked isn't null,
                // so this must be the second icon the player clicked
                // Set its color to black
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                // Check to see if the player won
                CheckForWinner();

                // If the player clicked two matching icons, keep them 
                // black and reset firstClicked and secondClicked 
                // so the player can click another icon
                if (firstClicked.Text == secondClicked.Text)
                {
                    if (currPlayer == 1 || currPlayer == 0)
                    {
                        streakP1++;
                        intScore1 += (10 * streakP1);
                        lblspeler1.Text = "Speler 1 score:" + intScore1.ToString();
                    }
                    else
                    {
                        streakP2++;
                        intScore2 += (10 * streakP2);
                        lblspeler2.Text = "Speler 2 score:" + intScore2.ToString();
                    }
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                else
                {
                    allowClick = false;
                    //Check if the 'previous' player is 1.
                    if (currPlayer == 1 || currPlayer == 0)
                    {
                        //Check if player 2 is already out of time.
                        if (p2Done == false)
                        {
                            streakP1 = 0;
                            currPlayer = 2;
                            //Pauzeer timer1
                            timer.Stop();

                            MessageBox.Show("Speler 2 is nu aan de beurt.");
                            timer1.Start();
                            //Initialize if player2 is starting his first round, else resume timer.
                            if (beginTurnP2)
                            {
                                //Begin timer2
                                startGameTimerP2(true);
                                beginTurnP2 = false;
                            }
                            else
                            {
                                //Hervat timer2
                                timer2.Start();

                            }
                        }
                    }
                    else
                    {
                        //Check if player 1 is already out of time.
                        if (p1Done == false)
                        {

                            streakP2 = 0;
                            currPlayer = 1;
                            //Pauzeer timer2
                            timer2.Stop();
                            MessageBox.Show("Speler 1 is nu aan de beurt.");
                            timer.Start();
                            //Hervat timer1
                            timer1.Start();
                        }
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckForWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            intScore1 = intScore1 + 60 - (60 - time);
            intScore2 = intScore2 + 60 - (60 - time2);
            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            DialogResult dialogResult = MessageBox.Show("U heeft gewonnen!", "Wilt u nog een keer spelen?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AssignIconsToSquares();
                allowClick = true;
                startGameTimer(true);
                startGameTimerP2(false);
                button1.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            lblspeler1.Text = "Speler 1 score:" + intScore1.ToString();
            lblspeler2.Text = "Speler 2 score:" + intScore2.ToString();
        }


        private void startGame(object sender, EventArgs e)
        {
            AssignIconsToSquares();
            allowClick = true;
            startGameTimer(true);
            startGameTimerP2(false);
            button1.Enabled = false;
        }

        Highscores HighscoresForm = new Highscores();

    }
}

